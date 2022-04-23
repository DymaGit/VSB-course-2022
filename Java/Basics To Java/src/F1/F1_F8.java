package F1;

import java.util.Scanner;

public class F1_F8 {
	public static void mainx(String[] args) {

		Scanner sc = new Scanner(System.in);

		int mesic;
		String vystup;
		System.out.println("zadej èíslo mìsíce");
		mesic = sc.nextInt();
		vystup = pocetdnimesiceF(mesic); // funkce
		System.out.printf("%d mìsíc má: %s dnù", mesic, vystup); // funkce
	}

	public static String pocetdnimesiceF(int cislo) // funkce
	{
		String vyber;

		switch (cislo) {
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12:
			vyber = "31";
			break;
		case 2:
			vyber = "28";
			break;
		case 4:
		case 6:
		case 9:
		case 11:
			vyber = "30";
			break;
		default:
			vyber = "špatný vstup";
			break;
		}
		return vyber;
	}
}
