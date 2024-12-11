namespace Together_Culture
{
    internal static class Program
    {
        public static Title Title
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            // Beginning the application with a Title Screen.
            Application.Run(new Title());
        }
    }
}