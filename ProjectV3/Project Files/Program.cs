using ProjectV3;

namespace MajorProject
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
            Forms.FiniteStateTable = new FiniteStateForm();
            Forms.StudentLogin = new StudnetLoginPage();
            Forms.MainWindow = new MainForm();
            Forms.StudentRegisterForm = new StudentRegister();
            Forms.Frontpage = new FrontPage();
            Forms.TeacherLogin = new TeacherLoginPage();
            Forms.TeacherReg = new ProjectV3.User_Forms.Login_Forms.TeacherRegister();
            Application.Run(new FrontPage());
        }
    }
}