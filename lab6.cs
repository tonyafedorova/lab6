using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    delegate float mulordiv(int p1, int p2);

    class Program
    {
        static float mul(int p1, int p2) { return p1 * p2; }
        static float div(int p1, int p2) { return p1 / p2; }
        static void mulordivMethod(string str, int i1, int i2, mulordiv mulordivParam)
        {
            float Result = mulordivParam(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }
        static void mulordivMethodFunc(string str, int i1, int i2, Func<int, int, float> mulordivParam)
        {
            float Result = mulordivParam(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }
       /* static void mulordivMethodAction(string str, int i1, int i2, Action<int, int> mulordivParam)
        {
            void Result = mulordivParam(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }
        */

            static void Main(string[] args)
        {
            int i1 = 6;
            int i2 = 2;

            mulordivMethod("Умножение: ", i1, i2, mul);
            mulordivMethod("Деление: ", i1, i2, div);

            mulordivMethod("Создание экземпляра делегата на основе лямбда-выражения 1: ", i1, i2,
            (int x, int y) =>
            {
                int z = x * y;
                return z;
            }
             );
            mulordivMethod("Создание экземпляра делегата на основе лямбда-выражения 2: ", i1, i2,
            (x, y) =>
            {
                return x * y;
            }
             );
            mulordivMethod("Создание экземпляра делегата на основе лямбда-выражения 3: ", i1, i2, (x, y) => x/y );

            Console.WriteLine("\nИспользование обощенного делегата Func<>");
            mulordivMethodFunc("Создание экземпляра делегата на основе метода:", i1, i2, div);
            Console.WriteLine("\nИспользование обощенного делегата Action<>");
            //mulordivMethodAction("Создание экземпляра делегата на основе метода:", i1, i2, div);

        }
    }
}
