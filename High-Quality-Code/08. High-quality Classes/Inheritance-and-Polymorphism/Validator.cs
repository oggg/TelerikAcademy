using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public static class Validator
    {
        public static void Name(string name)
        {
            if (name == string.Empty || name == null)
            {
                throw new ArgumentNullException("No name provided");
            }
        }
    }
}
