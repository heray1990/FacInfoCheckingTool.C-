using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FacInfoCheckingTool.CSharp
{
    class OutputLog
    {
        public static void ShowLog(TextBox txtBoxLog, string log)
        {
            // Clear the textBoxLog if there are more than 100 lines in it.
            if (txtBoxLog.GetLineFromCharIndex(txtBoxLog.Text.Length) > 100)
                txtBoxLog.Text = "";

            txtBoxLog.AppendText("> " + log);
            txtBoxLog.AppendText(Environment.NewLine);
            txtBoxLog.ScrollToCaret();

            SaveLogInFile(log);
        }

        private static void SaveLogInFile(string log)
        {
            string logPath = Path.GetDirectoryName(Application.ExecutablePath);

            System.IO.StreamWriter sw = System.IO.File.AppendText(logPath
                + @"\" + DateTime.Now.ToString("yyyy-MM-dd") + @".log");
            sw.WriteLine(DateTime.Now.ToString("HH:mm:ss > ") + log);
            sw.Close();
            sw.Dispose();
        }
    }
}
