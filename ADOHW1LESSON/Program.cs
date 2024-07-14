using System.Data.SqlClient;

namespace ADOHW1LESSON
{


    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new RegisterWin());


        }
    }
}