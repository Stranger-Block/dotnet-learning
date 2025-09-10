using System.Security.Cryptography.X509Certificates;
using UdemyProject.Course_Fundamentals.Hello_World;
using UdemyProject.Course_Fundamentals.System_Console_Class;

public class Program
{
    private static void Main(string[] args)
    {
        bool runTheProject = false;

        if (runTheProject)
        {
            Hello_Class.Hello_Function();
        }
        else
        {
            SystemConsoleClass.SystemConsoleClassFunction();
        }
    }
}