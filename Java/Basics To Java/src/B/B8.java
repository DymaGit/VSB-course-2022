package B;

import java.util.Scanner;

public class B8 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.println("zadej znak");
		char znak = sc.next().charAt(0);

		if (znak >= 48 && znak <= 57)
			System.out.println("znak je ��slo");
		else if (znak >= 65 && znak <= 90)
			System.out.println("znak je velk� p�smeno");
		else if (znak >= 97 && znak <= 122)
			System.out.println("znak je mal� p�smeno");
	}
}
