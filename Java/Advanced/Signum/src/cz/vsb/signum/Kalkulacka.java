package cz.vsb.signum;

public class Kalkulacka {

	public double secti(double a, double b) {
		return a + b;
	}

	public double odecti(double a, double b) {
		return a - b;
	}

	public double del(double a, double b) {
		return a / b;
	}

	public double nasob(double a, double b) {
		return a * b;
	}

	public int sectiOdDo(int odCisla, int doCisla) {
		int soucet = 0;

		for (int i = odCisla; i <= doCisla; i++)
			soucet = soucet + i;
		return soucet;
	}
}
