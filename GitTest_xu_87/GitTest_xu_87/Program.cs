using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace GitTest_xu_87
{
    public delegate void MyDel(string a);
    class Person {
       public static void seng(string a) {
           Console.WriteLine("我的名字叫"+a);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

          // MyDel my=new MyDel(Person.seng);
            MyDel my= Person.seng;
            my("令狐冲");
           Console.ReadKey();
           
        }
    }
}
