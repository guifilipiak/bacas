using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace MudarSenha
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("==============================");
            Console.WriteLine("Redefinir Senha ApisulCard");
            Console.WriteLine("==============================");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                var cript = FormsAuthentication.HashPasswordForStoringInConfigFile(Console.ReadLine(), "sha1");
                Console.WriteLine(cript);
                Clipboard.SetText(cript);
                Console.WriteLine("Copiado para área de transferência!");
                Console.WriteLine(Environment.NewLine);
            }

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
