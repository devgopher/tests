/*
 * User: Igor
 * Date: 28.11.2015
 * Time: 20:40
 */
using System;

namespace tests
{
	class Program
	{
		public static void Main(string[] args)
		{
			double a = 0.0, b = 0.0;
			
			Console.WriteLine("Введите длины катетов: ");
			Console.WriteLine("a = ");
			if (!Double.TryParse(Console.ReadLine(), out a))
			{
				Console.WriteLine("Ошибка разбора строк!" );
				return;
			}
			
			Console.WriteLine("b = ");
			if (!Double.TryParse(Console.ReadLine(), out b))
			{
				Console.WriteLine("Ошибка разбора строк!" );
				return;
			}
			
			// Самое главное
			var square = RightTriangle.GetSquare( Double.MaxValue, Double.MaxValue );			
			
			Console.Write("Площадь треугольника: "+square.ToString());
			Console.ReadKey(true);
		}
	}
}