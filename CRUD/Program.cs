using MySqlConnector;
namespace CRUD
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static MySqlConnection db_conn = new ("Host=localhost;User=root;Password=porfavorentrar;Database=proyecto");

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new UserMenu());
        }
    }
}