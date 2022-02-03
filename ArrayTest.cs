using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using PO_String_Array;


FilterArray filterarray = new FilterArray();
ArrayList array1 = new ArrayList(){1, 2, "a", "b"};
ArrayList array2 = new ArrayList(){1, "a", "b", 0, 15};
ArrayList array3 = new ArrayList(){1, 2, "aasf", "1", "123", 123};
ArrayList answer = new ArrayList();

answer = filterarray.Filter(array1);
filterarray.Print(array1, answer, "Test 1:");

answer = filterarray.Filter(array2);
filterarray.Print(array2, answer, "Test 2:");

answer = filterarray.Filter(array3);
filterarray.Print(array3, answer, "Test 3:");
