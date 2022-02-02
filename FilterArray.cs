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
        public static ArrayList Filter(ArrayList arr)
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
    }
}
