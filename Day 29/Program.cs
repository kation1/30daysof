﻿using System.CodeDom.Compiler;
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



	static void Main(string[] args)
	{

		int t = Convert.ToInt32(Console.ReadLine());
		for (int tItr = 0; tItr < t; tItr++)
		{
			string[] nk = Console.ReadLine().Split(' ');

			int n = Convert.ToInt32(nk[0]);

			int k = Convert.ToInt32(nk[1]);
			int gre = 0;

			for (int i = 0; i < n; i++)
			{
				for (int j = i + 1; j <= n; j++)
				{

					int bit = i & j;
					if (bit > gre && bit < k)
					{
						gre = bit;
					}

				}

			}
			Console.WriteLine(gre);

		}

	}

}



