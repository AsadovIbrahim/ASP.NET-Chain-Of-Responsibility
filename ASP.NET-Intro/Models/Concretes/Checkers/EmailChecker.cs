using ASP.NET_Intro.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_Intro.Models.Concretes.Checkers
{
    public class EmailChecker : BaseChecker
    {
        public override void Check(object? request)
        {
            if(request is Person person)
            {
                if(!string.IsNullOrEmpty(person.Email) && person.Email.Contains('@')) {
                    Console.WriteLine("Email is Correct...");
                    Next?.Check(request);
                }
                else
                {
                    Console.WriteLine("Wrong Email!");
                }
            }
        }
    }
}
