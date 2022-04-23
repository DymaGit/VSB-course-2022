package Dodatecne;

import java.util.Scanner;

public class Ee6 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.println("zadje slovo");
		String slovo = sc.next();
		String vypis = "";

		for (int i = slovo.length() - 1; i >= 0; i--)
			vypis = vypis + slovo.charAt(i);

		if (slovo.equals(vypis))
			System.out.println("slovo je palindrom");
		else
			System.out.println("slovo není palindrom");

	}
}
