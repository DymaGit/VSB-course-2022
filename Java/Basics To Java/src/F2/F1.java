package F2;

import java.util.Scanner;

public class F1 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);
		int[] poleuspory = new int[5];
		int[] pole2;
		int procenta;

		System.out.println("zadej úspory 5ti osob");
		for (int i = 0; i <= 4; i++) {
			poleuspory[i] = sc.nextInt();
		}
		System.out.println("zadej úrok v procentech");
		procenta = sc.nextInt();

		pole2 = sporeniF(poleuspory, procenta); // funkce

		for (int i = 0; i <= 4; i++) // funkce
			System.out.println(pole2[i]);
	}

	public static int[] sporeniF(int[] pole, int navyseni) // funkce
	{
		int[] uschovna = new int[pole.length];

		for (int i = 0; i <= 4; i++) {
			uschovna[i] = pole[i] + (pole[i] / 100 * navyseni);
		}
		return uschovna;
	}
}
