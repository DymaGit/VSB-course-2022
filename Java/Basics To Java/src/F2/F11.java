package F2;

import java.util.Scanner;

public class F11 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);

		String slovo;
		String vystup;
		System.out.println("zadej slovo.. bude zakódované");
		slovo = sc.nextLine();
		vystup = sifraF(slovo); // funkce
		System.out.println(vystup); // funkce
	}

	static String sifraF(String text) // funkce
	{
		char znak;
		String prevod = "";
		// tady neøeším pøesah nad Z.. a jenom easy šifrování o 1
		for (int i = 0; i < text.length(); i++) {
			znak = text.charAt(i);
			prevod = prevod + (char) (znak + 1);
		}
		return prevod;
	}
}
