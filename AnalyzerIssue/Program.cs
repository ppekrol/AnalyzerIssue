using System;
using System.Threading.Tasks;

namespace AnalyzerIssue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private async Task Sample()
        {
            await Task.Delay(100).ConfigureAwait(false);
        }
    }
}