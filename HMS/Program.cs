namespace HMS
{
    internal static class Program
    {
        /// <summary>
        /// Static variables.
        /// </summary>
        public static string title = "Hospital Management System";

        public static Database.Manager databaseManager = new();

        public static Forms.LoginForm? loginForm;

        public static Database.User? user;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Form entry point.
            ApplicationConfiguration.Initialize();

            loginForm = new();
            Application.Run(loginForm);
        }
    }
}