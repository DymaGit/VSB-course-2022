package D;

import java.util.Random;
import java.util.Scanner;

public class D6 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);
		Random r = new Random();
		int odhad;
		int nahoda;

		do {
			nahoda = r.nextInt(1, 11);
			System.out.println("Hádej co padlo..");
			odhad = sc.nextInt();

			if (odhad == nahoda)
				System.out.println("TREFA!");
			else
				System.out.println("špatnì!");
		} while (odhad != nahoda);
		sc.close();
	}
}
