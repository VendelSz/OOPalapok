using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPalapok
{
	public class Emberek
	{
		private List<Ember> lista;

		public Emberek(int db)
		{
			lista = new List<Ember>();
			Random random = new Random();

			for (int i = 0; i < db; i++)
			{
				double testSuly = Math.Round(random.NextDouble() * 100 + 50, 1);
				int testMagassag = random.Next(150, 200);
				lista.Add(new Ember(testSuly, testMagassag));
			}
		}

		public override string ToString()
		{
			string eredmeny = "Testsúly(kg) | Magasság(cm) | TTI       | Testalkat\n";
			eredmeny += "-------------------------------------------------\n";

			foreach (var ember in lista)
			{
				eredmeny += ember.ToString() + "\n";
			}

			return eredmeny;
		}

		public double AtlagTestsuly()
		{
			double osszeg = 0;
			foreach (var ember in lista)
			{
				osszeg += ember.GetTestSuly();
			}
			return osszeg / lista.Count;
		}

		public double AtlagTestmagassag()
		{
			double osszeg = 0;
			foreach (var ember in lista)
			{
				osszeg += ember.GetTestMagassag();
			}
			return osszeg / lista.Count;
		}
	}
}
