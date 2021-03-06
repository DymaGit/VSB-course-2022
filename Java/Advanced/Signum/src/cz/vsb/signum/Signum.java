package cz.vsb.signum;

public class Signum {

	public static int znamenko(int cislo) {
		if (cislo > 0)
			return 1;
		else if (cislo < 0)
			return -1;
		else
			return 0;
	}

	public double znamenko(String s) {
		int cislo = Integer.parseInt(s);
		if (cislo > 0)
			return 1;
		else if (cislo < 0)
			return -1;
		else
			return 0;

	}

	public static void main(String[] args) {
		Signum sg1 = new Signum();
		System.out.println(sg1.znamenko(5));
		System.out.println(sg1.znamenko(0));
		System.out.println(sg1.znamenko("5"));
		System.out.println(sg1.znamenko("-5"));
		System.out.println(sg1.znamenko("0"));
		System.out.println(sg1.znamenko("5.5"));
		System.out.println(sg1.znamenko("?"));

	}

}
