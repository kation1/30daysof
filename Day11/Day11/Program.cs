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
	static void Main(string[] args)
	{
		int[][] arr = new int[6][];

		for (int i = 0; i < 6; i++)
		{
			arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
		}

		int total = -81;
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				int newTotal =
					 arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
					+ arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1]
					+ arr[i + 2][j + 2];

				if (newTotal > total)
				{
					total = newTotal;
				}
			}
		}
		Console.WriteLine(total);

	}
}


//Stuff Dave showed me 
/*
static void DoStuff()
{
	for (int i = 0; i < A.Length; i++)
	{
		for (int j = 0; j < A.Length; j++)
		{
			Console.Write(A[i][j] + " ");
		}
		Console.WriteLine();
	}
}
}
            int[][] A = new int[][]
           {
               new int[] { 1, 1, 1, 0, 0, 0},
               new int[] { 0, 1, 0, 0, 0, 0},
               new int[] { 1, 1, 1, 0, 0, 0},
               new int[] { 0, 0, 2, 4, 4, 0},
               new int[] { 0, 0, 0, 2, 0, 0},
               new int[] { 0, 0, 1, 2, 4, 0}
           };

*/
