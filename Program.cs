namespace Assignment_3._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] numbers = { 1, 5, 3 };
            int[] numbers2 = { 9, 8, 3 };
            int[] numbers3 = { 1, 2, 3 };
            int search = 5;
            int search2 = 3;
            int search3 = 4;
            int index = Array.IndexOf(numbers, search); 
            int index2 = Array.IndexOf(numbers2, search2);
            int index3 = Array.IndexOf(numbers3, search3);

			foreach (int number in numbers) 
			{ 
				Console.Write(number + " "); 
			}
			Console.WriteLine($"\nThe index of {search} is: {index}");

			foreach (int number2 in numbers2)
			{
				Console.Write(number2 + " ");
			}
			Console.WriteLine($"\nThe index of {search2} is: {index2}");

			foreach (int number3 in numbers3)
			{
				Console.Write(number3 + " ");
			}
			Console.WriteLine($"\nThe index of {search3} is: {index3}");
		}
    }
}
