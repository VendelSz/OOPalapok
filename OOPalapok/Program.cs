namespace OOPalapok
{
	class Program
	{
		static void Main(string[] args)
		{
			Ember ember1 = new Ember(70.5, 175);
			Console.WriteLine(ember1.ToString());
			Console.WriteLine($"Testtömegindex: {ember1.TestTomegIndex()}");
			Console.WriteLine($"Normális testtömegindex: {ember1.NormalTTI()}");
            Console.WriteLine();

            Ember ember2 = new Ember(50.0, 180);
			Console.WriteLine(ember2.ToString());
			Console.WriteLine($"Testtömegindex: {ember2.TestTomegIndex()}");
			Console.WriteLine($"Normális testtömegindex: {ember2.NormalTTI()}");
            Console.WriteLine();

            Ember ember3 = new Ember(90.0, 160);
			Console.WriteLine(ember3.ToString());
			Console.WriteLine($"Testtömegindex: {ember3.TestTomegIndex()}");
			Console.WriteLine($"Normális testtömegindex: {ember3.NormalTTI()}");
            Console.WriteLine();
        }
	}
}