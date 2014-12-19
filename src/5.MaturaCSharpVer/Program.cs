using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Numerics;
using System.Linq;


namespace ConsoleApplication5
{
	class Program
	{
		static void Main(string[] args)
		{
			numbers()
				.Select(trace)
				.Select(lastDigit)
				.Distinct()
				.Select(logResult)
				.ToList();


			Console.WriteLine("end");
			Console.ReadLine();
		}


		private static IEnumerable<BigInteger> numbers()
		{
			var i = new BigInteger(0);

			while (true)
			{
				yield return i;
				i += 1;
			}
		}

		private static BigInteger trace(BigInteger val)
		{
			if(val%new BigInteger(100000000) == 0) Console.WriteLine("c# " + val);

			return val;
		}

		private static char lastDigit(BigInteger val)
		{
			var x = (val*val).ToString();
			return x[x.Length - 1];
		}

		private static char logResult(char val)
		{
			Console.Write(" {0}", val);
			return val;
		}
	}
}
