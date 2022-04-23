package F2;

import java.util.Random;

public class F6 {
	public static void mainx(String[] args) {

		int[] pole1 = new int[19];
		int[] polevystup;
		String vypis2 = "";
		String vypis1 = "";
		Random r = new Random();

		for (int i = 0; i <= 18; i++) {
			pole1[i] = r.nextInt(1, 11);
			vypis1 = vypis1 + pole1[i] + " ";
		}
		polevystup = sudacislazpoleF(pole1); // funkce

		for (int i : polevystup) // funkce
		{
			if (i != 0)
				vypis2 = vypis2 + i + " ";
		}
		System.out.printf("padlé èísla: %s %npouze sudá èísla: %s", vypis1, vypis2);

	}

	static int[] sudacislazpoleF(int[] p) {
		int[] sude = new int[19];

		for (int i = 0; i <= 18; i++) {
			if (p[i] % 2 == 0)
				sude[i] = p[i];
		}
		return sude;
	}
}
