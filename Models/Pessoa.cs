using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projetos_C_.Models
{
    public class Pessoa
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Hi, my name is " + 
            $"{Name}, \ne tenho {Age} anos");
        }
    }
}