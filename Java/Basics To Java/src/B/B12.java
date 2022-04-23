package B;

import java.util.Scanner;

public class B12 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.println("je horko? a/n");
		char odpoved1 = sc.next().charAt(0);
		System.out.println("je den? a/n");
		char odpoved2 = sc.next().charAt(0);

		if ((odpoved1 == 'a' || odpoved1 == 'A') && (odpoved2 == 'a' || odpoved2 == 'A'))
			System.out.println("bež si tedy zaplavat");
		else
			System.out.println("tak nic, zùstaò doma");
	}
}
