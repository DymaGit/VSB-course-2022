package D;

import java.util.Scanner;

public class D3 {
public static void mainx(String[] args) {
	Scanner sc = new Scanner(System.in);
	
    String vypis = "";
    int cisla, rozdil=0;

    System.out.println("zadej prvn� �len posloupnosti");
    int prvni = sc.nextInt();
    System.out.println("zadej druh� �len posloupnosti");
    int druhy = sc.nextInt();
    System.out.println("zadej posledn� �len posloupnosti");
    int posledni = sc.nextInt();
    cisla = prvni;

    cisla = cisla + rozdil;
    vypis = vypis + cisla + " ";
    do
    {
        rozdil = druhy - prvni;
        cisla = cisla + rozdil;
        if (cisla <= posledni)
            vypis = vypis + cisla + " ";
    }
    while (cisla < posledni);

    System.out.println();
    System.out.println("line�rn� posloupnost: " + vypis);
}
}
