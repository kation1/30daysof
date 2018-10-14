using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
	static void Main(String[] args)
	{
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		Dictionary<string, int> phonebook = new Dictionary<string, int>();

		int n = Convert.ToInt32(Console.ReadLine());
		for (int i = 0; i <= n -1; i++)
		{
			string name = Console.ReadLine();
			int number = Convert.ToInt32(Console.ReadLine());
			phonebook.Add(name, number);
		}
		for (int i = 0; i < n; i++)
		{
			string q = Console.ReadLine();
			if (phonebook.ContainsKey(q))
			{
				string qqq = Convert.ToString(phonebook[q]);
				Console.WriteLine(q + "=" + qqq);
			}
			else
			{
				Console.WriteLine("Not found");
			}
		}
	}
}

