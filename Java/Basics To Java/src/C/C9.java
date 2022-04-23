package C;

import java.util.Scanner;

public class C9 {
	public static void mainx(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("zadej èíslo do 100");
		int cislo=sc.nextInt();
		
		for(int i=1; i<= cislo;i++) {
			if (cislo%i==0)
				System.out.print(i+ " ");
		}
	}
}
