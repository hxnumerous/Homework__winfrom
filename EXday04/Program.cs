namespace EXday04
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
            //Application.Run(new LimitDel());
            //Application.Run(new ChangeSize());
            //Application.Run(new MouseEnterTip());
            //Application.Run(new LimitLength());
            //Application.Run(new SelectListBox());
            //Application.Run(new GotListBox());
            //Application.Run(new CheckPwd());
            //Application.Run(new NumSpit());
            Application.Run(new ChangeUpOrDown());
            //Application.Run(new TotalPrice());
        }
    }
}