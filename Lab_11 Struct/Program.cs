using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Разработать структуру для решения линейного уравнения 0=kx+b.
 * Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. 
 * Для решения уравнения предусмотреть метод Root.
 * Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.*/
namespace Lab_11_Struct
{
    struct Equation
    {
        public double k;
        public double b;
        
        
        public double Root()
        {
            double x=-b/k;
            return x;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменные k и b");
            double a = Convert.ToDouble(Console.ReadLine());
            double aa = Convert.ToDouble(Console.ReadLine());
            Equation eq = new Equation { k=a, b=aa };
            double x=eq.Root();
            Console.WriteLine("Корень уравнения\n"+x);
            Console.ReadKey();
        }
    }
}
