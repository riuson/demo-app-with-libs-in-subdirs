using ClassLibrary1;
using System;

namespace ConsoleAppMain
{
    public class Runner : MarshalByRefObject, IDisposable
    {
        public void Dispose()
        {
        }

        public void Run(AppStartInfo startInfo)
        {
            try
            {
                Class1 a = new Class1();
                a.Run();
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.Message);
                System.Diagnostics.Debug.WriteLine(exc.Source);
                System.Diagnostics.Debug.WriteLine(exc.StackTrace);
            }
        }
    }
}
