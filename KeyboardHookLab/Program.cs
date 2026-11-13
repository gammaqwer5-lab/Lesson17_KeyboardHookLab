namespace KeyboardHookLab
{
    // `Application.Run()` запускает цикл обработки сообщений Windows Forms. 
    // Пока окно работает, приложение получает и обрабатывает сообщения, в том числе связанные с клавиатурой.
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}