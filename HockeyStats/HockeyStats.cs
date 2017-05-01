using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HockeyStats
{
    static class HockeyStats
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            SQLiteConnection m_dbConnection;
            m_dbConnection = ConnectToDatabase();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Arena());

        }

        private static SQLiteConnection ConnectToDatabase()
        {
            return new SQLiteConnection($"Data Source={AppDomain.CurrentDomain.BaseDirectory}hockeystats.db; Version=3");
        }
    }
}
