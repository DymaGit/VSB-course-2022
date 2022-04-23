package E;

public class E11 {
	public static void mainx(String[] args) {
		int[][] pole1 = new int[4][4];
		int z = 1;

		for (int y = 0; y <= 3; y++) {
			for (int x = 0; x <= 3; x++) {
				pole1[x][y] = z;
				z += 1;
				if (x == 3)
					System.out.printf("%-4d %n", pole1[x][y]);
				else
					System.out.printf("%-4d", pole1[x][y]);
			}
		}
		System.out.println();
		z = 1;
		for (int y = 0; y <= 3; y++) {
			for (int x = 0; x <= 3; x++) {

				pole1[x][y] = z;
				z += 1;
				if (x == 3)
					System.out.printf("%-4d %n", pole1[y][x]);
				else
					System.out.printf("%-4d", pole1[y][x]);
			}
		}
	}
}