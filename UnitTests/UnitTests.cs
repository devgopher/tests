/*
 * User: Igor
 * Date: 28.11.2015
 * Time: 21:01
 */
using System;
using NUnit.Framework;

namespace tests.UnitTests
{
	[TestFixture]
	public class UnitTests
	{
		[Test]
		[TestCase( 2.0, 10.0, 10.0 )]
		[TestCase( 4.0, 4.0, 8.0 )]
		[TestCase( 3.0, 4.0, 6.0 )]
		[TestCase( 0.5, 0.5, 0.125 )]
		public void TestSquareComputation( double a, double b, double expected_square )
		{
			Assert.AreEqual( RightTriangle.GetSquare( a, b ), expected_square );
		}
		
		[Test]
		public void TestExceptionThrowing()
		{
			Assert.Throws( typeof( TriangleException ),
			              () => {
			              	RightTriangle.GetSquare( -0.3, 0.5 );
			              } );
			Assert.Throws( typeof( TriangleException ),
			              () => {
			              	RightTriangle.GetSquare( 1.3, -1.5 );
			              } );
			Assert.Throws( typeof( TriangleException ),
			              () => {
			              	RightTriangle.GetSquare( Double.NaN, 0.3 );
			              } );
		}
	}
}
