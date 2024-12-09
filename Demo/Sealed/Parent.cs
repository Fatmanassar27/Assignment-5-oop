using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
    internal class Parent
    {

        public virtual int Id
        {
            get { return Id; }
            set { Id = value; }
        }
        public virtual void print () 
        {
            Console.WriteLine("I am Parent .");
        }
    }

    internal class Child : Parent
    {
        public override sealed int Id 
        {
            get { return base.Id; }
            set { base.Id = value > 3000 ? 3000 : value; }
        }
        
        public override  void print()
        {
            Console.WriteLine("I am child ."); 
        }
    }

    internal class GrandChild : Child
    {
        //public override int Id
        //{
        //    get { return base.Id; }
        //    set { base.Id = value > 3000 ? 3000 : value; }
        //}
        public override void print()
        {
            Console.WriteLine("I am grand child .");
        }
    }
}
