﻿using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
	static void Main(String[] args)
	{
		/* for i in range(int(input())):
			string = input()
			print(string[0::2], string[1::2])*/


		int L = Convert.ToInt32(Console.ReadLine());
		string[] words = new string[L];
		int i = 0;

		while (i < L)
		{
			string w = Console.ReadLine();
			words[i++] = w;
		}

		i = 0;
		while (i < L)
		{
			char[] c = words[i].ToCharArray();
			string evens = "";
			string odds = "";
			for (int x = 0; x < c.Length; x++)
			{
				if (x % 2 == 0) evens += c[x];
				if (x % 2 != 0) odds += c[x];
			}
			Console.WriteLine(evens + " " + odds);
			i++;

		}
	}
}
