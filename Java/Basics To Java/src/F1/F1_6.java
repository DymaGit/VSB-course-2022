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
        case 1: vyber = "Pond�l�"; break;
        case 2: vyber = "�ter�"; break;
        case 3: vyber = "St�eda"; break;
        case 4: vyber = "�tvrtek"; break;
        case 5: vyber = "P�tek"; break;
        case 6: vyber = "Sobota"; break;
        case 7: vyber = "Ned�le"; break;
        default: vyber = "�patn� zad�n�"; break;
    }
    return vyber;
}
}
