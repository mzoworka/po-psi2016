﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjGru2
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                Kom kom = new Kom();
                Rejestracja rej = new Rejestracja();
                Lista lista = new Lista();
                Rozmowa rozmowa = new Rozmowa();
                Application.Run(kom);
        }
    }
}
