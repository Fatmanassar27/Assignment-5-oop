namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Point3D P1 = new Point3D ();
            //P1.x = int.Parse(Console.ReadLine());
            //int.TryParse(Console.ReadLine(),out int y1);
            //P1.y = y1 ;
            //P1.z = Convert.ToInt32(Console.ReadLine());
            //Point3D P2 = new Point3D ();
            //P2.x = int.Parse(Console.ReadLine());
            //int.TryParse(Console.ReadLine(),out int y2);
            //P2.y = y2 ;
            //P2.z = Convert.ToInt32(Console.ReadLine());
            //if (P1 == P2)
            //    Console.WriteLine(true);
            //else Console.WriteLine(false);

            //Point3D[] point3Ds = new Point3D[4];
            //point3Ds[0] = new Point3D (1, 1, 9);
            //point3Ds[1] = new Point3D (5, 4, 7);
            //point3Ds[2] = new Point3D (3, 1, 1);
            //point3Ds[3] = new Point3D (4, 2, 0);

            //Array.Sort(point3Ds);

            //Point3D [] point3Ds2 = (Point3D[]) point3Ds.Clone();

            //foreach (Point3D point3D in point3Ds2)
            //    Console.WriteLine(point3D.ToString());

            //Console.WriteLine ( Maths.Add(2, 5) );
            //Console.WriteLine ( Maths.Subtract (12, 9) );
            //Console.WriteLine ( Maths.Multiply (2, 10) ) ;
            //Console.WriteLine ( Maths.Divide (5, 2) );


            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine ( D1.ToString() );
            ////Output: Hours: 1, Minutes: 10, Seconds: 15

            //D1 = new Duration(3600);
            //Console.WriteLine ( D1.ToString() );
            ////Output: Hours: 1, Minutes: 0, Seconds: 0

            //Duration D2 = new Duration(7800);
            //Console.WriteLine ( D2.ToString() );
            ////Output: Hours: 2, Minutes: 10, Seconds: 0

            //Duration D3 = new Duration(666);
            //Console.WriteLine ( D3.ToString() );
            ////Output: Minutes: 11, Seconds: 6


            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());

            Console.WriteLine("===================");

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2.ToString());

            Console.WriteLine("===================");

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString());

            DateTime Obj = (DateTime)D1;

            Console.WriteLine(Obj.ToString());
            //Duration D3 = new Duration();
            //D3 = D1 + D2;

            //Console.WriteLine("\n=======D3 = D1 + D2;=======\n");
            //Console.WriteLine(D3.ToString());

            Duration D3 = new Duration();
            //D3 = D1 ++ ;
            //D3 = ++D1 ;
            //D3 = --D1 ;
            //D3 = D1 - D2 ;

            //Console.WriteLine("\n=======D3 = D1++ ;=======\n");
            //Console.WriteLine(D3.ToString());
            //// Hours: 3, Minutes :20, Seconds :15


            //D3 = D1 + 7800;
            //Console.WriteLine("\n======= D3 = D1 + 7800;=======\n");
            //Console.WriteLine(D3.ToString());
            //// Hours: 3, Minutes :20, Seconds :15

            //D3 = 666 + D3;
            //Console.WriteLine("\n=======D3 = 666 + D3;=======\n");
            //Console.WriteLine(D3.ToString());
            //// Hours: 3, Minutes :31, Seconds :21
            //D1 = new Duration(1,2,1);
            //D2 = new Duration(1,2,1);
            //Console.WriteLine(D2.ToString());
            //Console.WriteLine(D1.ToString());
            //if (D2 > D1) { Console.WriteLine("D2 IS GREATER THAN D1"); }
            //if (D1 < D2) { Console.WriteLine("D1 IS LESS THAN D2"); }

            //if (D2 >= D1) { Console.WriteLine("D2 IS GREATER THAN D1"); }
            //if (D1 <= D2) { Console.WriteLine("D1 IS LESS THAN D2"); }


        }
    }
}
