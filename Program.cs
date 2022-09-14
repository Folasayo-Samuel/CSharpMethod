
namespace CSharpMethod
{
	class Program
	{
		static void Main(string[]args)
		{
			SayHi("Folasayo", 25);
			SayHi("Samuel", 24);
			SayHi("Olayemi", 23);

            var cubeNumber = cube(5);
            Console.WriteLine(cubeNumber);


			Console.ReadLine();
		}
		
		public static void SayHi(string name, int age)
		{
			Console.WriteLine($"Hello {name}");
		}
		
		public static int cube(int num)
		{
			var result  = num * num * num;
			return result;
		}
		
	}
}