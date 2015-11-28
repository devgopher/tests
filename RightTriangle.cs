using System;

namespace tests
{
	/// <summary>
	/// Класс для операций с прямоугольными треугольниками
	/// </summary>
	public static class RightTriangle
	{
		/// <summary>
		/// Получаем площадь прямоугольного треугольника
		/// </summary>
		/// <param name="a">Катет A</param>
		/// <param name="b">Катет B</param>
		/// <returns>Площадь</returns>
		public static double GetSquare( double a, double b ) {
			double ret = 0.0;
			try {
				if ( Double.IsNaN(a) || Double.IsNaN(b) )
					throw new TriangleException("NotANumber!");
				
				if ( a < 0.0 || b < 0.0 )
					throw new TriangleException("Катеты треугольника должны иметь положительную длину!");
				
				ret = checked( 0.5 * a * b );

			} catch ( OverflowException ex ) {
				throw new TriangleException("Произошло арифметическое переполнение: "+ex.Message, ex);
			}

			return ret;
		}
	}
}
