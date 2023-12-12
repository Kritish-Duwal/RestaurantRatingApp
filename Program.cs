using System;
using System.Windows.Forms;

namespace RestaurantRatingApp
{
    static class Program
    {

        /// The main entry point for the application.

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splashscreen());

        }
    }
}
