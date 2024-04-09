using ASP.NET_Intro.Models;
using ASP.NET_Intro.Models.Abstracts;

namespace ASP.NET_Intro
{
    public class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("Ibrahim", "ibrahimasadov@gmail.com", "ibrahim123");
            CheckerDirector checkerDirector = new CheckerDirector();
            checkerDirector.MakePerson(person);
        }
    }
}
