using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_ValueStrore
{
    class Program
    {
        static void Main(string[] args)
        {
         
                var d = new MyDictionary();
                try
                {
                    Console.WriteLine(d["Cats"]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                d["Cats"] = 42;
                d["Dogs"] = 17;
               
        }
    }
}
