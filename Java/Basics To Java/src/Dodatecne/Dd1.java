package Dodatecne;

import java.util.Scanner;

public class Dd1 {
	public static void mainx(String[] args) {

		Scanner sc = new Scanner(System.in);

		float F = 32;
		int celsia;
		System.out.println("zadej stupnì");
		do {
			celsia = sc.nextInt();

			if (celsia < -275)
				System.out.println("WARNING - taková teplota neexistuje \nzadej znovu");
			else {
				float vypocet = (float) (F + (celsia * 1.80));
				System.out.printf("%d celsia je %.2f far", celsia, vypocet);
			}
		} while (celsia < -275);

	}
}