package Dodatecne;

import java.util.Scanner;

public class Ee2 {
	public static void mainx(String[] args) {
		int[] pole = new int[20];
		int x = -1;
		boolean ok = false;
		String vypis = "";
		Scanner sc = new Scanner(System.in);
		System.out.println("zadej èísla");
		do {
			x++;
			pole[x] = sc.nextInt();
		} while (pole[x] != 0);

		for (int i = 0; i <= x - 3; i++) {
			if (pole[i] == (pole[i + 1] - 1) && (pole[i + 1] == (pole[i + 2] - 1))) {
				ok = true;
				vypis = vypis + pole[i] + " " + pole[i + 1] + " " + pole[i + 2] + "\n";
			}
		}
		if (ok == true)
			System.out.println("program má alespoò jendu postupku \n" + vypis);
		else
			System.out.println("žádná postupka nebyla nalezena" );
	}
}
