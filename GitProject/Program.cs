using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GitProject
{
	class Program
	{
		static void Main(string[] args)
		{
			var rand = new Random();
			int number = rand.Next(101);
			int guess = 200;
			int tries = 0;
			Console.WriteLine("I'm thinking of a number between 0 and 100. Try to guess it!");
			while (guess != number)
			{
				tries++;
				guess = Convert.ToInt32(Console.ReadLine());
				if (guess > number)
				{
					Console.WriteLine("Too high!");
				}
				else if (guess < number)
				{
					Console.WriteLine("Too low!");
				}
			}
			Console.WriteLine("That's right!");
			Console.Write("Total guesses: ");
			Console.Write(tries);
			Thread.Sleep(2000);
		}
	}
}
