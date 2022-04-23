package F1;

import java.util.Scanner;

public class F1_6 {
public static void mainx(String[] args) {
	Scanner sc = new Scanner(System.in);
    String vystup = "";
    int cislo;
    cislo = sc.nextInt();
    vystup = denF(cislo); //funkce
    
    System.out.println(vystup); //funkce
    
}

public static String denF(int number) //funkce
{
    String vyber;

    switch (number)
    {
        case 1: vyber = "Pondìlí"; break;
        case 2: vyber = "Úterý"; break;
        case 3: vyber = "Støeda"; break;
        case 4: vyber = "Ètvrtek"; break;
        case 5: vyber = "Pátek"; break;
        case 6: vyber = "Sobota"; break;
        case 7: vyber = "Nedìle"; break;
        default: vyber = "Špatné zadání"; break;
    }
    return vyber;
}
}
