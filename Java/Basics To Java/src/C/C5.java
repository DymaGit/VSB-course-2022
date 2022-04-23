package C;

import java.util.Random;

public class C5 {
	public static void mainx(String[] args) {
		Random r = new Random();
		int soucet = 0;
		for (int i = 0; i <= 19; i++) {
			int nahoda = r.nextInt(10, 51);
			soucet = soucet + nahoda;
			System.out.print(nahoda + " ");
		}
		float prumer = soucet / 20;
		float rozdil = 30 - prumer;
		System.out.println();
		System.out.println(Math.abs(rozdil));
	}
}
