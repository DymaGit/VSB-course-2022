package Dodatecne;

public class Cc2 {
	public static void mainx(String[] args) {
		String hvezda = "";
		String mezera = "";
		String hvezda2 = "";
		String mezera2 = "";

		for (int i = 0; i <= 4; i++) {

			hvezda = hvezda + mezera;

			for (int x = 0; x <= 9; x++) {
				if (x == 9)
					hvezda = hvezda + "*" + "\n";
				else
					hvezda = hvezda + "*";
			}
			mezera = mezera + " ";
		}

		for (int i = 0; i <= 4; i++) {

			for (int x = 3 - i; x >= 0; x--) {
				mezera2 = mezera2 + " ";

			}
			hvezda2 = hvezda2 + mezera2;
			for (int x = 0; x <= 9; x++) {
				if (x == 9)
					hvezda2 = hvezda2 + "*" + "\n";
				else
					hvezda2 = hvezda2 + "*";
			}
			mezera2 = "";

		}

		System.out.println(hvezda + "\n" + hvezda2);
	}
}
