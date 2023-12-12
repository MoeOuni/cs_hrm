namespace hrm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Application.Run(new Login());
            // Application.Run(new Home());
            // Application.Run(new LeaveRequest());
            // Application.Run(new LeaveList());
            Application.Run(new AddUser());
        }
    }
}