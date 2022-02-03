using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_String_Array
{
    public class FilterArray
    {
        public ArrayList Filter(ArrayList arr)
        {
            ArrayList array = new ArrayList();
            foreach (object o in arr)
            {
                if (o.GetType() == typeof(int))
                {
                    array.Add(o);
                }
            }
            return array;
        }
        public void Print(ArrayList start, ArrayList end, string test)
        {
            Console.WriteLine("");
            Console.WriteLine(test);
            Console.WriteLine("Original Array");
            foreach (object o in start)
            {
                Console.Write(o.ToString() + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Filtered Array");
            foreach (object o in end)
            {
                Console.Write(o.ToString() + " ");
            }
        }
    }
}
