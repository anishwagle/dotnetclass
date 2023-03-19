using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    public class Animal : IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Sound");
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
        public void Run2()
        {
            throw new NotImplementedException();
        }
    }
}
