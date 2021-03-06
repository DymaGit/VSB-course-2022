package cz.vsb.signum;

public class Pole {
	public double getMin(double[] input) {

		double min = input[0];
		for (int i = 0; i <= input.length - 1; i++)
			if (min > input[i])
				min = input[i];
		return min;
	}

	public double getMax(double[] input) {

		double max = input[0];
		for (int i = 0; i <= input.length - 1; i++)
			if (max < input[i])
				max = input[i];
		return max;
	}

	public double soucet(double[] input) {

		double soucet = 0;
		for (int i = 0; i <= input.length - 1; i++)
			soucet += input[i];
		return soucet;
	}

	public double rozdil(double[] input) {
		double rozdil = input[0];
		for (int i = 1; i <= input.length - 1; i++)
			rozdil -= input[i];
		return rozdil;
	}

	public double soucin(double[] input) {
		double soucin = input[0];
		for (int i = 1; i <= input.length - 1; i++)
			soucin *= input[i];
		return soucin;
	}

	public double deleni(double[] input) {

		double deleni = input[0];
		for (int i = 1; i <= input.length - 1; i++)
			deleni /= input[i];
		return deleni;
	}
}
