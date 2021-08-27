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
			int tries = 0;
			Console.WriteLine("Enter the lower bound in your guessing range: ");
			int lower = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the higher bound in your guessing range: ");
			int higher = Convert.ToInt32(Console.ReadLine());
			int number = rand.Next(lower, higher + 1);
			int guess = higher + 20;
			Console.WriteLine($"I'm thinking of a number between {lower} and {higher}. Try guessing it!");
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
