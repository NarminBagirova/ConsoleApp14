using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Worker
    {
        private static int _idCounter=1;
        
        public int Id { get; set; }
        public string Fullname { get; set; }

        public double Salary { get; set; }
        public Position Position { get; set; }

        public Worker()
        {
            Id = _idCounter++;
        }

        public override string ToString()
        {
            return $"{Id} - {Fullname} - {Salary} - {Position}";
        }


    }
}
