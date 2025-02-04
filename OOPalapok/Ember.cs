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
			return $"Testsúly: {testSuly} kg, Magasság: {testMagassag} cm";
		}

		public double TestTomegIndex()
		{
			double magassagMeterben = testMagassag / 100.0;
			double tti = testSuly / (magassagMeterben * magassagMeterben);
			return Math.Round(tti, 2);
		}

		public bool NormalTTI()
		{
			double tti = TestTomegIndex();
			return tti >= 18.5 && tti < 25;
		}
	}
}
