using Abstraction.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Entities
{
    public class Carfactory : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Car();
        }
    }
}
