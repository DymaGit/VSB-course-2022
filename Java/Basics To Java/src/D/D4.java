package D;

import java.util.Scanner;

public class D4 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);
		int max, vyska;
		String nejvyssi, jmeno;

		System.out.println("zadej jm�no ��ka. 0 = konec");
		jmeno = sc.next();
		System.out.println("zadej v��ku ��ka.");
		vyska = sc.nextInt();
		max = vyska;
		nejvyssi = jmeno;

		do {
			System.out.println("zadej jm�no ��ka. 0 = konec");
			jmeno = sc.next();
			if (!jmeno.equals("0")) {
				System.out.println("zadej v��ku ��ka.");
				vyska = sc.nextInt();

				if (vyska > max) {
					max = vyska;
					nejvyssi = jmeno;
				}
			}
		} while (!jmeno.equals("0"));
		System.out.println("nejvy��� ��k je: " + nejvyssi + "\n" + "v��ka: " + max);
	}
}
