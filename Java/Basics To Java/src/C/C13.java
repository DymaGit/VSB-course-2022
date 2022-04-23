package C;

public class C13 {
	public static void mainx(String[] args) {

		String vypis = "    ";
		String vypis2 = "     ";

		for (int i = 1; i <= 10; i++)
			if (i == 10)
				vypis = vypis + i + "\n";
			else if (i == 9)
				vypis = vypis + i + "   ";
			else
				vypis = vypis + i + "    ";

		for (int i = 1; i <= 10; i++) {
			if (i == 10)
				vypis = vypis + i + "";
			else
				vypis = vypis + i + " ";

			for (int y = 1; y <= 10; y++)
				if (y % 10 == 0)
					vypis = vypis + " " + y * i + "\n";
				else

				if (y * i >= 90)
					vypis = vypis + "  " + y * i + "";
				else if (y * i >= 10)
					vypis = vypis + "  " + y * i + " ";
				else if (y * i == 90)
					vypis = vypis + " " + y * i + " ";
				else
					vypis = vypis + "  " + y * i + "  ";
		}

		System.out.println(vypis);

		for (int i = 1; i <= 10; i++) {
			if (i == 1) {
				System.out.print("     ");
			}
			if (i == 10)
				System.out.printf("%4d", i);
			else
				System.out.printf("%5d", i);
		}
		System.out.println();

		for (int i = 1; i <= 10; i++) {
			System.out.printf("%5d", i);

			for (int y = 1; y <= 10; y++)
				if (y == 10)
					System.out.printf("%5d%n", y * i);
				else
					System.out.printf("%5d", y * i);
		}

		System.out.println();

		for (int i = 1; i <= 10; i++) {
			if (i == 10)
				vypis2 = vypis2 + String.format("%5d%n", i);
			else
				vypis2 = vypis2 + String.format("%5d", i);
		}
		for (int i = 1; i <= 10; i++) {
			vypis2 = vypis2 + String.format("%5d", i);

			for (int y = 1; y <= 10; y++) {
				if (y == 10)
					vypis2 = vypis2 + String.format("%5d%n", i * y );
				else
					vypis2 = vypis2 + String.format("%5d", i * y);
			}
		}
		System.out.println(vypis2);

	}
}
