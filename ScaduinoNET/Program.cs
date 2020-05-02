using ScaduinoNET.DataBase;
using ScaduinoNET.ScaduinoWindows.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaduinoNET
{
    static class Program
    {
        public static ScaduinoApp Scaduino { get; set; }
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Scaduino = new ScaduinoApp();
            new StartScreen().Show();
            Application.Run();
        }
    }
}
