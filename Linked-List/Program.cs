using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList LList = new LinkedList();
            LList.Insert(3);
            LList.Insert(4);
            LList.Insert(7);
            LList.Insert(9);
            LList.Insert(5);
            LList.Insert(5);
            LList.Insert(3);// loi neu them vao dau List

            LList.Delete(3);
            LList.Traverse();
            Console.ReadLine();
        }
    }
}
