using Demo.Casting_Operator_Overloading;
using Demo.OperatorOverloading;
using Demo.Sealed;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operator overloading
            //Complex c01 = new Complex();
            //c01.Real = 5;
            //c01.Imagin = 2;
            //Console.WriteLine(c01);

            //Complex c02 = new Complex()
            //{ Real = 5, Imagin = 5 };
            //Console.WriteLine(c02);

            //Console.WriteLine("=================================");

            //Complex c03 = default;
            //c03 = c01 + c02;

            //Console.WriteLine(c03);
            //Console.WriteLine("=================================");

            //c03 = c01 - c02;
            //Console.WriteLine(c03);
            //Console.WriteLine("=================================");

            //c03 ++;
            //Console.WriteLine(c03);

            //Complex c02 = new Complex()
            //{ Real = 4, Imagin = 5 };
            //Console.WriteLine(c02);

            //Console.WriteLine("=================================");

            //Complex c03 = default;
            //c03 = ++c02;
            //c03 = c02++;
            //c03 = --c02;
            //c03 = c02--;
            //Console.WriteLine(c03);
            //if (c01< c02) 
            //    Console.WriteLine(true);
            //else Console.WriteLine(false);
            #endregion

            #region Casting Operator overloading
            //Complex c01 = new Complex() { Real = 5 , Imagin = 6};
            //int x = (int) c01;
            //string s = c01;
            //Console.WriteLine(c01);
            //Console.WriteLine(s);

            //User user = new User()
            //{
            //    Id = 1,
            //    Email = "fatma032@gmail.com",
            //    Name = "fatma nassar",
            //    Password = "password",
            //    SecurityTemb = new Guid()
            //};

            //UserViewModel viewModel = new UserViewModel();
            //viewModel = (UserViewModel)user;
            //Console.WriteLine(viewModel.FirstName + "\n" + viewModel.LastName + "\n" + viewModel.Email);
            #endregion
        }

    }
}
