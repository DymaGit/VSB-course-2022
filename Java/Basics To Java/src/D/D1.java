package D;

import java.util.Scanner;

public class D1 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);
		int soucet = 0, pocet;
		byte pocitadlo = 0, pocettrid;
		System.out.println("zadej kolik je ve t��d� ��k�. 0=konec");

		do {
			pocet = sc.nextInt();
			soucet = soucet + pocet;
			pocitadlo += 1;
		} while (pocet != 0);

		pocettrid = (byte) (pocitadlo - 1);
		float prumer = (float) soucet / pocettrid;
		System.out.println("celkem ��k�: " + soucet + "\n" + "pr�m�r: " + prumer);
		System.out.printf("celkem ��k�: %d%npr�m�r: %.1f", soucet, prumer);

	}
}
