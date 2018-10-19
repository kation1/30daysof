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
	/*
        while(n > 0):
        remainder = n%2; 
        n = n/2;
        Insert remainder to front of a list or push onto a stack

    Print list or stack
    */



	static void Main(string[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int rem = 0;
		int count = 0;
		int end = 0;
		Stack<int> L = new Stack<int>();
		while (n > 0)
		{
			rem = n % 2;
			L.Push(rem);
			n = n / 2;
		}
		foreach (var a in L)
		{
			if (a == 1)
			{
				count++;
			}
			else
			{
				if (count > end)
				{
					count = end;
				}
				count = 0;
			}
			if (count > end)
				end = count;
		}
		Console.WriteLine(end);
	}
}





