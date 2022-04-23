package F1;

import java.util.Scanner;

public class F1_9 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);
		String text, vystup, sub;

		System.out.println("zadej slovo a dostaneš ho obrácenì");
		text = sc.next();
		vystup = obrattextF(text); // funkce
		System.out.println(vystup); // funkce

	}

	public static String obrattextF(String slovo) // funkce
	{
		int delka = slovo.length();
		String vypis = "";
		for (int i = delka - 1; i >= 0; i--) {
			vypis = vypis + slovo.charAt(i);
		}
		return vypis;
	}
}
