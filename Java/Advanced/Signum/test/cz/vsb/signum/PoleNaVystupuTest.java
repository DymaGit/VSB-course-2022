package cz.vsb.signum;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

class PoleNaVystupuTest {

	PoleNaVystupu poleNaVystupu;
	private static final double ALFA = 0.001;

	@BeforeEach
	void setUp() throws Exception {
		poleNaVystupu = new PoleNaVystupu();
	}

	@Test
	void testPricist1() {

		double[] input = { 2, -88, -2.8, 74, -7, 4, 120, -58 };

		double[] actual = (poleNaVystupu.pricist1(input));
		assertArrayEquals(new double[] { 3, -87, -1.8, 75, -6, 5, 121, -57 }, actual, ALFA);
	}

}
