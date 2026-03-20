using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAdmin());
            //Application.Run(new FormXemHopDongChiTiet());
            //Application.Run(new FormNhapMKMoi());
            //Application.Run(new FormDoiMK());
        }
    }
}
