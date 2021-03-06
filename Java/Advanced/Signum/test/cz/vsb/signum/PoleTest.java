package cz.vsb.signum;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

class PoleTest {
	Pole pole;
	private static final double ALFA = 0.001;
	private static final double DELTA = 0.8;

	@BeforeEach
	void setUp() throws Exception {
		pole = new Pole();
	}

	@Test
	void testGetMin() {
		double[] input = { 2, -88, -2.8, 74, -7, 4, 120, -58 };

		double actual = (pole.getMin(input));
		assertEquals(-88, actual);
	}

	@Test
	void testGetMax() {
		double[] input = { 2, -88, -2.8, 74, -7, 4, 120, -58 };

		double actual = (pole.getMax(input));
		assertEquals(120, actual);
	}

	@Test
	void testSoucet() {
		double[] input = { 2, -88, -2.8, 74, -7, 4, 120, -58 };

		double actual = (pole.soucet(input));
		assertEquals(44.2, actual);
	}

	@Test
	void testRozdil() {
		double[] input = { 2, -88, -2.8, 74, -7, 4, 120, -58 };

		double actual = (pole.rozdil(input));
		assertEquals(-40.2, actual);
	}

	@Test
	void testSoucin() {
		double[] input = { 2, -88, -2.8 };

		double actual = (pole.soucin(input));
		assertEquals(492, actual, DELTA);
	}

	@Test
	void testDeleni() {
		double[] input = { 2, -88, -2.8 };

		double actual = (pole.deleni(input));
		assertEquals(0.008, actual, ALFA);
	}

}
