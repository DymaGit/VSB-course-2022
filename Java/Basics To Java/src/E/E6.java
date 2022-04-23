package E;

import java.util.Random;
import java.util.Scanner;

public class E6 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);
		char[] pole1 = new char[9];
		Random r = new Random();
		String vypis = "";
		int i = -1, x, n;

		do {
			i++;
			System.out.println("zadej písmeno. 0 = konec");
			pole1[i] = sc.next().charAt(0);
		} while (pole1[i] != '0');

		for (x = 0; x <= i - 1; x++) {
			n = r.nextInt(0, i - 1);
			vypis = vypis + pole1[n];
		}
		System.out.println(vypis);
	}
}
