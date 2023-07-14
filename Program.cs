using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAssign_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList elementList = new ArrayList();
            elementList.Add("Apple");
            elementList.Add("banana");
            elementList.Add("cherry");
            elementList.Add("data");
            elementList.Add("elderberry");
            foreach(var i in elementList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Total number of elements:\t "+elementList.Count);
           

            elementList.Add("fig");
            Console.WriteLine("*****adding element list****");
            foreach (var j in elementList)
            {
                Console.WriteLine(j);
            }
            elementList.Remove("banana");
            Console.WriteLine("*****Removing the  List*******");
            foreach(var k in elementList)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("********element list************");
            for(int i = 0; i < elementList.Count; i++)
            {
                Console.WriteLine(elementList[i]);
            }
            Console.ReadKey();
            
            
        }
    }
}
