/*
 * User: Igor
 * Date: 28.11.2015
 * Time: 20:47
 */
using System;
using System.Runtime.Serialization;

namespace tests
{
	/// <summary>
	/// Исключение для RightTriangle
	/// </summary>
	public class TriangleException : Exception, ISerializable
	{
		public TriangleException()
		{
		}

	 	public TriangleException(string message) : base(message)
		{
		}

		public TriangleException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// This constructor is needed for serialization.
		protected TriangleException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}