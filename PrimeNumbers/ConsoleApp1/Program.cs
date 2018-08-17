using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleEx.WriteLine("".PadLeft(100, '*'), ConsoleColor.Yellow);
			ConsoleEx.WriteLine("PrimeNumbers".PadLeft(50, '*').PadRight(100, '*'), ConsoleColor.Red);
			ConsoleEx.WriteLine("".PadLeft(100, '*'), ConsoleColor.Yellow);
			bool x = false;
			int a = 0;
			int b = 0;
			do
			{
				Console.Write("Write first number of analyzed range: ");
				
				try
				{
					a = Int32.Parse(Console.ReadLine());
				}
				catch (Exception e)
				{
					Console.WriteLine("Error" + e.Message);
				} 

				Console.Write("Write last number of analyzed range: ");
				try
				{
					b = Int32.Parse(Console.ReadLine());
				}
				catch (Exception e)
				{
					Console.WriteLine("Error" + e.Message);
				}

				if (a > b)
				{
					Console.WriteLine("Error - your first number is bigger than second");
				}

				x = a > b;
				
			}
			while (x);

			List<int> range = new List<int> { };
			for (int h = a; h <= b; h++)
				range.Add(h);

			List<int> primeNumber = new List<int> { };
			
			for(int i = 0; i<range.Count; i++) 
			{
				if(range[i]==0)
				{
					i += 2;
				}
				if (range[i] == 1)
				{
					i += 1;
				}
				int r = 0;
				for(int j = 1;j<=range[i];j++)
				{
					if(range[i]%j==0)
					{
						r++;
					}
				}
				if(r<=2)
				{
					primeNumber.Add(range[i]);
				}
			}
			Console.WriteLine("Prime numbers from analyzed range: ");
			Console.WriteLine();
			foreach (int elem in primeNumber){
				Console.Write (" "+ elem);
			}
			Console.ReadKey();
		}
	}
}
