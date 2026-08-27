namespace EXday03
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
            //Application.Run(new Form1());
            //Application.Run(new FoucsNoGo());
            //Application.Run(new MouseMoveAndLeave());
            //Application.Run(new CursorLocation());
            //Application.Run(new TextBoxGotFocus());
            //Application.Run(new InitFocusHieghtLigth());
            //Application.Run(new InitFocusOpen());
            //Application.Run(new KeyEnter());
            //Application.Run(new KeyEsc());
            //Application.Run(new KeyCtrl());
            //Application.Run(new LimitNum());
            Application.Run(new KeyMove());
            //Application.Run(new KeyTime());


        }
    }
}