using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPalapok
{
	public class Ember
	{
		private double testSuly;
		private int testMagassag;

		public Ember(double testSuly, int testMagassag)
		{
			this.testSuly = testSuly;
			this.testMagassag = testMagassag;
		}

		public override string ToString()
		{
			double tti = TestTomegIndex();
			string testalkat = Testalkat();

			return $"{testSuly,10:F1} | {testMagassag,10} | {tti,10:F2} | {testalkat,-12}";
		}

		public double TestTomegIndex()
		{
			double magassagMeterben = testMagassag / 100.0;
			double tti = testSuly / (magassagMeterben * magassagMeterben);
			return Math.Round(tti, 2);
		}

		public string Testalkat()
		{
			double tti = TestTomegIndex();
			if (tti < 18.5)
				return "alultáplált";
			else if (tti >= 18.5 && tti < 25)
				return "normál";
			else
				return "túlsúlyos";
		}

		public double GetTestSuly() => testSuly;
		public int GetTestMagassag() => testMagassag;
	}
}
