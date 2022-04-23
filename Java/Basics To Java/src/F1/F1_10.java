package F1;

import java.util.Scanner;

public class F1_10 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);

		String vystup;
		String text;
		System.out.println("zadej text s mezerama");
		text = sc.nextLine();
		vystup = bezmezerF(text); // funkce
		System.out.println(vystup); // funkce
	}
	public static String bezmezerF(String veta) // funkce
	{
		veta = veta.replace(" ", "");
		return veta;
	}
}
