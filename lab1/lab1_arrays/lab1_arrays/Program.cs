using System;
using System.Windows.Forms;

namespace lab1_arrays
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());                         
        }
    }
}
