using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SomeObject> someObjects = new List<SomeObject>();

            for (int i = 0; i < 100; i++)
            {
                someObjects.Add(new SomeObject(i));
                Console.WriteLine("Object created: ID -  " + someObjects[i]._id);
            }
            Console.ReadKey();
        }

    }
}
