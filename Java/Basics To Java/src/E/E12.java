package E;

import java.util.Random;

public class E12 {
	public static void mainx(String[] args) {

		int[] pole1 = new int[9];
		Random r = new Random();

		for (int i = 0; i <= 8; i++) {
			pole1[i] = r.nextInt(1, 11);

			System.out.printf("%-3d", pole1[i]);
		}

		System.out.println();

		for (int i = 1; i <= 7; i++) {
			if ((pole1[i] > pole1[i - 1]) && (pole1[i] > pole1[i + 1]))
				System.out.printf("%-3d", pole1[i]);
		}
	}
}
