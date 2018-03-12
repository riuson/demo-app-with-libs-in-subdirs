using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMain
{
    class Program
    {
        static void Main(string[] arguments)
        {
            try
            {
                AppStartInfo info = new AppStartInfo();
                info.Arguments = arguments;
                info.ExecutablePath = Program.GetExecutablePath();
                info.ExecutableDir = Path.GetDirectoryName(info.ExecutablePath);

                using (Domain<Runner> appInDomain = new Domain<Runner>())
                {
                    appInDomain.Object.Run(info);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static string GetExecutablePath()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            return path;
        }
    }
}
