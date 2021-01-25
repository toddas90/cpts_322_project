using Eto.Forms;

// I ONLY WORK ON WINDOWS
// ETO needs to link against platform-specific packages. I've only added Windows (at the moment). 
// It will work fine on the non-test project
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Application().Run(new HelloForm());
        }
    }
}