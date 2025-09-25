namespace Save_Scummer {
    internal static class Program {
        [STAThread]
        static void Main() {

            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());

        }
    }
}

