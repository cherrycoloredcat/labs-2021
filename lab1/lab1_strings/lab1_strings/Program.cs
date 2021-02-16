using System;
using System.Windows.Forms;

namespace lab1_strings
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStringReplace());
        }
    }
}
