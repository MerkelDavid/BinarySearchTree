using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            BST tree = new BST(68);
            //testing for equal head
 //           tree.Search(68);
            //testing for unequal to head
//            tree.Search(67);
            //testing add function
            tree.Add(11);
            tree.Add(50);
            tree.Add(25);
            tree.Add(61);

            tree.Add(200);
            tree.Add(69);
            tree.Add(210);
            tree.Add(211);

            //testing searches 
            tree.Search(25);
            tree.Search(211);

            //testing failed searches
            tree.Search(70);
            tree.Search(0);

            Console.ReadKey();
        }
    }
}
