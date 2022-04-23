package B;

import java.util.Scanner;

public class B15 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("jak je venku?");

		String odpoved = sc.next();

		switch (odpoved) {
		case "zima":
			System.out.println("se obleè..");
			break;
		case "vedro":
			System.out.println("se vysleè..");
			break;
		}
	}
}
