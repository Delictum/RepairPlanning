using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RepairPlanning.Util
{
    public static class Helpers
    {
        public static void StartupHelper()
        {
            var workingDirectory = Environment.CurrentDirectory;
            var pathHelper = Directory.GetParent(workingDirectory).Parent.FullName + "\\Util\\Helper.chm";
            if (File.Exists(pathHelper))
            {
                Process.Start(pathHelper);
            }
            else
            {
                MessageBox.Show("Файл-помощник отсутсвует.");
            }
        }

        public static void ValidPriceData(TextBox textBox, KeyPressEventArgs e)
        {
            if (e.KeyChar == 44 && !string.IsNullOrEmpty(textBox.Text) && !textBox.Text.Contains(','))
            {
                e.Handled = false;
                return;
            }

            if (e.KeyChar != 8 && textBox.Text.Contains(',') && (textBox.Text.Length - 3 == textBox.Text.IndexOf(',')))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }

        public static void CorrectionPrice(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                return;
            }

            if (textBox.Text.Contains(','))
            {
                if (textBox.Text[0] == ',')
                {
                    textBox.Text = textBox.Text.Insert(0, "0");
                }

                for (var i = 0; i < 2; i++)
                {
                    if (textBox.Text.Length - 1 != textBox.Text.IndexOf(',') + 2)
                    {
                        textBox.Text += "0";
                    }
                }
            }
            else
            {
                textBox.Text += ",00";
            }
        }

        public static bool CorrectionFilterPrice(TextBox textBoxPriceFrom, TextBox textBoxPriceTo)
        {
            CorrectionPrice(textBoxPriceFrom);
            CorrectionPrice(textBoxPriceTo);

            if (string.IsNullOrEmpty(textBoxPriceFrom.Text) || string.IsNullOrEmpty(textBoxPriceTo.Text))
            {
                return true;
            }

            if (double.Parse(textBoxPriceFrom.Text) > double.Parse(textBoxPriceTo.Text))
            {
                MessageBox.Show("Начальная сумма должна быть меньше конечной.");
                return false;
            }

            return true;
        }
    }
}
