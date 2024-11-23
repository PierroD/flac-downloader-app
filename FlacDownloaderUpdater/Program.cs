using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlacDownloaderUpdater
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                MessageBox.Show("Invalid arguments passed to updater.");
                return;
            }
            string downloadUrl = args[0];
            bool isDarkMode;

            // Parsing the boolean value safely
            if (!bool.TryParse(args[1], out isDarkMode))
            {
                MessageBox.Show("Invalid value for isDarkMode argument.");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormFlacDownloaderUpdater(downloadUrl, isDarkMode));
        }
    }
}
