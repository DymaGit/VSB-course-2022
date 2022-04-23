package B;

import java.util.Scanner;

public class B18 {
	public static void mainx(String[] args) {

		System.out.println("zadej èíslo mìsíce");
		Scanner sc = new Scanner(System.in);
		int mesic = sc.nextInt();

		switch (mesic) {
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12:
			System.out.println("mìsíc má 31 dní");
			break;
		case 2:
			System.out.println("mìsíc má 28 dní");
			break;
		default:
			System.out.println("mìsíc má 30 dní");
			break;
		}
	}
}
