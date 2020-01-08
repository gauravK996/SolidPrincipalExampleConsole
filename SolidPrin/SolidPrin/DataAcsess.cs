using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrin
{
    class DataAcsess:IDataacsess
    {
        public void Display()
        {
            Console.WriteLine("ddsdsd");
        }

        public string Getthename(int id)
        {
            return "gaurav Kumaya"; 
        }
    }
}
