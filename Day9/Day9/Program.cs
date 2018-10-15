using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
	static int Find_gcd(int a, int b)
	{
		if (a <= b)
		{
			Console.WriteLine(a);
		}
		else
		{
			Find_gcd(a, b);
		}
	}
static void Main(String[] args)
	{
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		int a = 0;
		int b = 0;
		a = Convert.ToInt32(Console.ReadLine());
		b = Convert.ToInt32(Console.ReadLine());
	}
}
