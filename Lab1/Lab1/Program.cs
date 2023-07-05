namespace Lab1;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello world!");
		Student stud = new Student("Andrey", "Bobovich", "Pavlovich", 8, 213, 2021, 'Б', "C#");
		Console.WriteLine(stud.ToString());
	}
}