package A;

import java.util.Scanner;

public class A13 {

	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.println("zadej d�lku odv�sny1 (cm)");
		int odvesna1 = sc.nextInt();
		System.out.println("zadej d�lku odv�sny1 (cm)");
		int odvesna2 = sc.nextInt();
		float vypocet = (float) Math.sqrt(Math.pow(odvesna1,2)+ Math.pow(odvesna2,2));
		System.out.println("p�epona je dlouh�: " + vypocet + "cm");
	}
}
