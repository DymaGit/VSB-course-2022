package F1;

import java.util.Scanner;

public class F1_1 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);
		float vstup, vystup;

		System.out.println("zadej stupnì --> pøevedou se na radiány");
		vstup = sc.nextFloat();
		vystup = radianF(vstup); // funkcee

		System.out.printf("%.0f stupòù je %.3f radiánù", vstup, vystup); // funkce
	}

	public static float radianF(float stupne) // funkce
	{
		float vypocet;
		vypocet = (float) (Math.PI / 180) * stupne;
		return vypocet;
	}
}
