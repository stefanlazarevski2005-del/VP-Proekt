namespace Balatro
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var context = new ApplicationContext();
            var form1 = new Form1(4);
            form1.Show();          // shown, but not passed to ApplicationContext as MainForm

            Application.Run(context);
        }
    }
}