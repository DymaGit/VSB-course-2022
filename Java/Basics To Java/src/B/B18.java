package B;

import java.util.Scanner;

public class B18 {
	public static void mainx(String[] args) {

		System.out.println("zadej ��slo m�s�ce");
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
			System.out.println("m�s�c m� 31 dn�");
			break;
		case 2:
			System.out.println("m�s�c m� 28 dn�");
			break;
		default:
			System.out.println("m�s�c m� 30 dn�");
			break;
		}
	}
}
