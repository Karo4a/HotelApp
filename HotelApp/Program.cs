using HotelApp.Forms;
using HotelApp.Models;
using System;
using System.Windows.Forms;

namespace HotelApp
{
    internal static class Program
    {
        /// <summary>
        /// Контекст базы данных
        /// </summary>
        public static ContextDb Context = new ContextDb();
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Context.Database.Exists())
            {
                MessageBox.Show("Ошибка подключения к базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
