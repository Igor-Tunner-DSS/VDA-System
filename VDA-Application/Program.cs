using System.Windows.Forms;
using VDA_Core.Controller;

namespace VDA_Application
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
            InitForm form = new InitForm();
            form.MaximizeBox = true;
            form.MinimizeBox = true;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(form);

        }
    }
}