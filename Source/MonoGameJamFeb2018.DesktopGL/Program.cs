using System;

namespace MonoGameJamFeb2018.DesktopGL
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new AfterglowGame())
                game.Run();
        }
    }
}
