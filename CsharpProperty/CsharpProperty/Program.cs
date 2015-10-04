using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProperty
{
    class Program
    {
      static void Main(string[] args)
        {
            Student sn = new Student();
            sn.Name = "Masud";
            sn.StudentId = 1203;
            sn.Dept = "CSE";
            Console.WriteLine(sn.Name);
            Console.WriteLine(sn.StudentId);
            Console.WriteLine(sn.Dept);
            Console.ReadLine();

        }

      
        }
        
    }

