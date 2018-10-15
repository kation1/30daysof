using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

	// Complete the factorial function below.
	static int factorial(int n)
	{
		if (n < 2)
		{
			return n;
		}

		return n*factorial(n - 1);
	}

	static void Main(string[] args)
	{
		//TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		Console.WriteLine("Enter an integer");

		int n = Convert.ToInt32(Console.ReadLine());

		int result = factorial(n);

		Console.WriteLine($"Factorial of {n} is {result}");
		Console.ReadKey();
		//textWriter.WriteLine(result);

		//textWriter.Flush();
		//textWriter.Close();
	}
}
