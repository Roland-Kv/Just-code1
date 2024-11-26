using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_code1
{ 
    public delegate void MyDelegate(string str);

    public class MyDelegateTest
    {
        MyDelegate myDelegate;

        public MyDelegateTest()
        {
            myDelegate = TheCityIs; 
        }

        public void TheCityIs(string str)
        {
            Console.WriteLine("The city is " + str);
        }

        public void DoALL()
        {
            this.Method(this.myDelegate);
            MyClass myClass = new MyClass();
            myClass.MyMethod(this.myDelegate);
        }

        public void Method(MyDelegate md)
        {
            md?.Invoke("Tbilisi");
        }
    }
    public class MyClass
    {
        public void MyMethod(MyDelegate md)
        {
            md?.Invoke("Batimi");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegateTest mdTest = new MyDelegateTest();

            mdTest.DoALL();

        }
    }
}
