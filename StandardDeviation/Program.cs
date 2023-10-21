using System;

namespace StandardDeviation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateCorrelation();
        }

        public static void CalculateStandardDeviation()
        {

            int ave = 0; double a=0, b=0;
            Console.Write("Enter size of array : ");
            var size = int.Parse(Console.ReadLine());

            var array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Number of array : ");
                var x = int.Parse(Console.ReadLine());
                array.SetValue(x, i);
                ave +=  x;
            }

            ave = ave / size;


            for (int i = 0; i < array.Length; i++)
            {
                a += Math.Pow(array[i] - ave, 2);
            }

            b = a / size;

            var sd = Math.Sqrt(b);

            Console.WriteLine($"standard deviation = {sd} ");

        }

        public static void CalculateCorrelation()
        {
            Console.Write("Enter the number of size :");
            int size = int.Parse(Console.ReadLine());
            var arrayX = new int[size];
            var arrayy = new int[size];
            double aveX = 0, avey = 0;
            double XMSquared = 0, YMSquared = 0;
            double ProductDeviation = 0, r = 0;

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter the number of array x :");
                arrayX[i] = int.Parse(Console.ReadLine());
                aveX += arrayX[i];

                Console.Write("Enter the number of array y :");
                arrayy[i] = int.Parse(Console.ReadLine());
                avey += arrayy[i];
            }
            aveX = aveX / size;
            avey = avey / size;
 

            for (int i = 0; i < arrayX.Length; i++)
            {
                XMSquared += Math.Pow(arrayX[i] - aveX, 2);
            }

            for (int i = 0; i < arrayy.Length; i++)
            {
                YMSquared += Math.Pow(arrayy[i] - avey, 2);
            }

            for (int i = 0; i < size; i++)
            {
                
                    ProductDeviation += ((arrayX[i] - aveX) * (arrayy[i] - avey));
                
            }


            r = ProductDeviation / Math.Sqrt(XMSquared * YMSquared);

            Console.WriteLine("Correlation = " +r);

        }
    }
}
