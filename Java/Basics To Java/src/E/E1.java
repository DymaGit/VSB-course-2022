package E;

import java.util.Scanner;

public class E1 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);
		int[] pole1 = new int[15];
		byte i = 0;
		byte min, y = 0;

		System.out.println("zadej èíslo. 0=konec");
		pole1[i] = sc.nextInt();

		min = (byte) pole1[0];
		y++;
		do {
			i++;
			System.out.println("zadej èíslo. 0=konec");
			pole1[i] = sc.nextInt();

			if (pole1[i] != 0) {
				if (pole1[i] <= min) {
					if (pole1[i] < min) {
						y = 0;
					}
					min = (byte) pole1[i];
					y++;
				}
			}
		} while (pole1[i] != 0);
		System.out.println("nejmenší èíslo je :" + min + "\n" + "je tam :" + y + "x");
	}
}
