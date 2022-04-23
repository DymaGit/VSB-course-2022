package E;

import java.util.Random;

public class E10 {
	public static void mainx(String[] args) {

		int[][] pole1 = new int[4][4];
		int min, radek = 0, sloupec = 0;
		Random r = new Random();

		System.out.println("vygenerováno 16 èísel");

		for (int y = 0; y <= 3; y++) {
			for (int x = 0; x <= 3; x++)

				pole1[x][y] = r.nextInt(1, 11);
		}

		min = pole1[0][0];
		for (int y = 0; y <= 3; y++) {
			for (int x = 0; x <= 3; x++) {

				if (pole1[x][y] <= min) {
					min = pole1[x][y];
					sloupec = x + 1;
					radek = y + 1;
				}
				if (x == 3)
					System.out.printf("%-3d %n", pole1[x][y]);
				else
					System.out.printf("%-3d", pole1[x][y]);
			}
		}
		System.out.printf("minimum je: %d %nsloupec: %d %nradek: %d", min, sloupec, radek);
	}
}
