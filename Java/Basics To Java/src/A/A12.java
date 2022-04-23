package A;

import java.util.Scanner;

public class A12 {

	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.println("jaký je prùmìr tvojeho bazénu?");
		int prumer = sc.nextInt();
		System.out.println("zadej výšku bazénu");
		int vyska = sc.nextInt();
		float vypocet = (float) (Math.PI * Math.pow(prumer / 2, 2) * vyska);
		System.out.printf("objem bazénu je %.3f m3", vypocet);
	}
}
