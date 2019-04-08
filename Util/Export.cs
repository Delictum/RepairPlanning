using System;
using System.Reflection;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace RepairPlanning.Util
{
    public static class Export
    {
        public static void ToExcel(DataGridView dataGridView)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
                ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
                ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet) ExcelWorkBook.Worksheets.get_Item(1);

                for (var i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (var j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        ExcelApp.Cells[i + 1, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                    }
                }

                ExcelApp.Visible = true;
                ExcelApp.UserControl = true;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static void ToWord(DataGridView dataGridView)
        {
            var sfd = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                FileName = "export.docx"
            };

            var filename = sfd.FileName;

            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                if (dataGridView.Rows.Count != 0)
                {
                    int RowCount = dataGridView.Rows.Count;
                    int ColumnCount = dataGridView.Columns.Count;
                    Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                    int r = 0;
                    for (int c = 0; c <= ColumnCount - 1; c++)
                        for (r = 0; r <= RowCount - 1; r++)
                            DataArray[r, c] = dataGridView.Rows[r].Cells[c].Value;

                    Word.Document oDoc = new Word.Document();
                    oDoc.Application.Visible = true;

                    oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;

                    dynamic oRange = oDoc.Content.Application.Selection.Range;
                    string oTemp = "";
                    for (r = 0; r <= RowCount - 1; r++)
                        for (int c = 0; c <= ColumnCount - 1; c++)
                            oTemp = oTemp + DataArray[r, c] + "\t";

                    oRange.Text = oTemp;
                    object oMissing = Missing.Value;
                    object separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                    object applyBorders = true;
                    object autoFit = true;
                    object autoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                    oRange.ConvertToTable(ref separator, ref RowCount, ref ColumnCount,
                                          Type.Missing, Type.Missing, ref applyBorders,
                                          Type.Missing, Type.Missing, Type.Missing,
                                          Type.Missing, Type.Missing, Type.Missing,
                                          Type.Missing, ref autoFit, ref autoFitBehavior, Type.Missing);
                    oRange.Select();

                    oDoc.Application.Selection.Tables[1].Select();
                    oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                    oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    oDoc.Application.Selection.InsertRowsAbove(1);
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();

                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                    for (var c = 0; c <= ColumnCount - 1; c++)
                    {
                        oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = dataGridView.Columns[c].HeaderText;
                    }

                    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                    foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                    {
                        Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                        headerRange.Font.Size = 16;
                        headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    }

                    oDoc.SaveAs(filename, ref oMissing, ref oMissing, ref oMissing,
                        ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                        ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                        ref oMissing, ref oMissing);
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}
