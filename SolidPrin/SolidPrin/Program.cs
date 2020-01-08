using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrin
{
    class Program
    {
        IDataacsess _dataAcsess;
        public Program()
        {
           // _dataAcsess = Datafactory.Getobject(); 
        }
        public Program(IDataacsess dataacsess)
        {
            _dataAcsess = dataacsess;
        }
        public void Display()
        {

            Console.WriteLine(_dataAcsess.Getthename(11));
        }
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Display();
            Console.Read();
        }
    }
}
