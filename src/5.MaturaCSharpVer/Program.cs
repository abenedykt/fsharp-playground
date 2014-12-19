using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace ConsoleApplication5
{
	class Program
	{
		static void Main()
		{
			Numbers()
				.Select(Trace)
				.Select(LastDigit)
				.Distinct()
				.Select(LogResult)
				.ToList();

			Console.WriteLine("end");
			Console.ReadLine();
		}

		private static IEnumerable<BigInteger> Numbers()
		{
			var i = new BigInteger(0);

			while (true)
			{
				yield return i;
				i += 1;
			}
		}

		private static BigInteger Trace(BigInteger val)
		{
			if(val%new BigInteger(100000000) == 0) Console.WriteLine("c# " + val);

			return val;
		}

		private static char LastDigit(BigInteger val)
		{
			var x = (val*val).ToString();
			return x[x.Length - 1];
		}

		private static char LogResult(char val)
		{
			Console.Write(" {0}", val);
			return val;
		}
	}
}