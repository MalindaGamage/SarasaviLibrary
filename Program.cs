using SarasaviLibrary.Database;
using SarasaviLibrary.UI;
namespace SarasaviLibrary
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var context = new LibraryContext();

            Application.Run(new MainForm(context));
        }
    }
}
