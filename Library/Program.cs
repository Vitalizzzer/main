using System;
using System.Windows.Forms; 

namespace Library
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var sqlQueries = new SqlQueries();
            sqlQueries.DbFileCreation();
            sqlQueries.DbTableCreation();
            Application.Run(new MainForm());
        }
        
    }
}
