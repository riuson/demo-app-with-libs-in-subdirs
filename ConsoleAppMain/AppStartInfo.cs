using System;

namespace ConsoleAppMain
{
    [Serializable]
    public class AppStartInfo
    {
        public string[] Arguments { get; set; }
        public string ExecutableDir { get; set; }
        public string ExecutablePath { get; set; }

        public AppStartInfo()
        {
            this.Arguments = new string[] { };
            this.ExecutableDir = String.Empty;
            this.ExecutablePath = String.Empty;
        }
    }
}
