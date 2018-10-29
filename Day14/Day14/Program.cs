using System;
using System.Linq;

class Difference
{
	private int[] elements;
	public int maximumDifference;


//My Work


	public Difference(int[] elements)
	{
		this.elements = elements;
		int[] a = elements;
	}
	public void computeDifference()
	{

		int max = elements.Max();
		int min = elements.Min();

		maximumDifference = (max - min);
	}

	//provided by hackerrack
} // End of Difference Class

class Solution
{
	static void Main(string[] args)
	{
		Convert.ToInt32(Console.ReadLine());

		int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

		Difference d = new Difference(a);

		d.computeDifference();

		Console.Write(d.maximumDifference);
	}
}