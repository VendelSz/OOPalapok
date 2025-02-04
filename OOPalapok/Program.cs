namespace OOPalapok
{
	class Program
	{
		static void Main(string[] args)
		{
			Emberek emberek = new Emberek(5);

			Console.WriteLine(emberek.ToString());

			Console.WriteLine($"Átlagos testsúly: {emberek.AtlagTestsuly():F1} kg");
			Console.WriteLine($"Átlagos testmagasság: {emberek.AtlagTestmagassag():F1} cm");
		}
	}
}