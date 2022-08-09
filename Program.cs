using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR
{
    /* internal class Program
     {
         // default constructior
         public Program()//compilar make constructor like this
         {
            // Console.WriteLine("This is default constructor");
         }
         static void Main(string[] args)
         {
             Program p = new Program();
             Console.ReadLine();
         }
     }*/


    // parameteries Constructor
    /*  public class A
      {
          public A(int a)
          {

              Console.WriteLine("This is Parametries constructor :{0} ", a);
          }
      }


      internal class Program
      {

          static void Main(string[] args)
          {
              A p = new A(20);
              Console.ReadLine();
          }
      }*/
    //-----------------------------------Static Constructor------------------------------

    /*internal class Program
    {
        static  Program()
        {
            Console.WriteLine("This is static constructor");
        }
        public  Program()
        {
            Console.WriteLine("This is Instance Constructor");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Program obj2 = new Program();
            Console.ReadLine();
        }
    } */


    //------------------------------------ Copy Constructor---------------------------------
    internal class Program
    {
        public Program(int a)
        {
            Console.WriteLine("This is  constructor:{0}",a);
        }
        public Program(Program E)
        {
  
            Console.WriteLine("This is Copy Constructor:{0}",obj);
        }
        static void Main(string[] args)
        {
            Program obj = new Program(20);
            Program obj2 = new Program(obj);
            Console.ReadLine();
        }
    }
}
