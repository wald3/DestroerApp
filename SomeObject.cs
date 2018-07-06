using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorApp
{
    public class SomeObject
    {
        public int _id;

        public SomeObject(int id)
        {
            _id = id;
        }
        
        ~SomeObject()
        {
            Console.WriteLine("Object destroyed: ID - " + _id);
            Console.ReadKey();
        }

    }
}
