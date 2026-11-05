using System;
namespace GenericPractice
{
	public class Operation<T> where T:class
	{
		public T Value { get; set; }


		public void Display(T message)
		{
			Console.WriteLine($"Message is {message}.");
		}
	}

}