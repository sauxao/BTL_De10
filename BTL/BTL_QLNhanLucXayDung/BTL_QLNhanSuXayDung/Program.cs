using System;
using System.Windows.Forms;
using BTL_QLNhanSuXayDung.GUI;

namespace BTL_QLNhanSuXayDung
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Ép chương trình chạy FormMain làm màn hình chính gốc
            Application.Run(new FormMain());
        }
    }
}