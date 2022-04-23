package cz.vsb.signum;

public class PoleNaVystupu {

	public double[] pricist1(double[] input) {
		double[] sada = new double[input.length];

		for (int i = 0; i <= input.length - 1; i++) {
			sada[i] = input[i] + 1;
		}

		return sada;

	}

}
