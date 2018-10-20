using System;
using System.Linq;

class Person
{
	protected string firstName;
	protected string lastName;
	protected int id;

	public Person() { }
	public Person(string firstName, string lastName, int identification)
	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.id = identification;
	}
	public void printPerson()
	{
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
	}
}
class Student : Person
{
	public Student(string firstName, string lastName, int id, int[] scores)
	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.id = id;
		this.Scores = scores;
	}

	public int[] Scores { get; private set; }

	public char Calculate()
	{

		int total = 0;
		char grade = 'X';

		for (int i = 0; i < Scores.Length; i++)
		{
			total = Scores[i] + total;
		}

		int average = total / Scores.Length;
		if (average <= 100 && average>=90)
			grade = 'O';
		else if (average < 90 && average >=80)
			grade = 'E';
		else if (average < 80 && average >=70)
			grade = 'A';
		else if (average < 70 && average >=55)
			grade = 'P';
		else if (average < 55 && average >40)
			grade = 'D';
		else if (average < 40)
			grade = 'T';
		return grade;
	}
}

class Solution
{
	static void Main()
	{
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
		string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
		int[] scores = new int[numScores];
		for (int i = 0; i < numScores; i++)
		{
			scores[i] = Convert.ToInt32(inputs[i]);
		}

		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}