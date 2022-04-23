package C;

public class C14 {
	public static void mainx(String[] args) {
		
        String vypis = "";

        for (int i = 1; i <= 10; i++)
        {
            for (int y = 1; y <= i; y++)
                vypis = vypis + "*";
            vypis = vypis + "\n";
        }
        for (int i = 9; i >= 1; i--)
        {
            for (int y = 1; y <= i; y++)
                vypis = vypis + "*";
            vypis = vypis + "\n";
        }
        System.out.print(vypis);
	}
}
