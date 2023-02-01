using G12_20221005;
using System.Security.Cryptography.X509Certificates;

class Program
{
	static void Main()
	{
		int[] numbers = { 2, 3, 13, 8, 9, 1 };

		//var result = numbers.Where(n => n < 6);
		//var result = ListHelper.Where(numbers, n => n < 6);

		var resultAny=ListHelper.Any(numbers, n => n < 2);
		Console.WriteLine(resultAny);

        var resultAny1 = ListHelper.All(numbers, n => n < 12);
        Console.WriteLine(resultAny1);

        var resultAny2 = ListHelper.Where(numbers, n => n < 8.5);
        
        foreach (var n in resultAny2)
		{
			Console.WriteLine(n);
		}

		//Func<double, double, double> f = delegate (double x, double y)
		//{
		//	return x + y;
		//};

		//Func<double, double, double> f = (x, y) => x + y;

		//Console.WriteLine(f(12.5, 5));
	}

	static bool foo(double x, double y=5)
	{
		if (x < y)
			return true;

		return false;
	}

	static double Sum(double x, double y) => x + y;
}