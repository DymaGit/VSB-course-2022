package cz.vsb.signum;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

class KalkulackaTest {

	Kalkulacka kalkulacka;
	private static final double DELTA = 0.0001;

	@BeforeEach
	void setUp() throws Exception {
		kalkulacka = new Kalkulacka();
	}

	@Test
	void testSecti() {
		double actual = (kalkulacka.secti(6, 5));
		assertEquals(11, actual);
	}

	@Test
	void testOdecti() {
		double actual = (kalkulacka.odecti(6, 5));
		assertEquals(1, actual);
	}

	@Test
	void testNasob() {
		double actual = (kalkulacka.nasob(6, 5));
		assertEquals(30, actual);
	}

	@Test
	void testDel() {
		double actual = (kalkulacka.del(1, 6));
		assertEquals(0.1666, actual, DELTA);
	}

	@Test
	void testOdDo() {
		int actual = (kalkulacka.sectiOdDo(1, 3));
		assertEquals(6, actual);
	}
}
