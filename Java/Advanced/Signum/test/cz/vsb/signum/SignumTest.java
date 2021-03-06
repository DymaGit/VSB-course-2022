package cz.vsb.signum;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

class SignumTest {
	Signum sg1;
	private static final double DELTA = 0.0000001;

	@BeforeAll
	static void setUpBeforeClass() throws Exception {
	}

	@BeforeEach
	void setUp() throws Exception {
		sg1 = new Signum();
	}

	@AfterEach
	void tearDown() throws Exception {
	}

	@AfterAll
	static void tearDownAfterClass() throws Exception {
	}

	@Test
	void testZnamenkoIntKladne() {
		int actual = (sg1.znamenko(5));
		assertEquals(1, actual);

	}

	@Test
	void testZnamenkoIntZaporne() {

		int actual = (sg1.znamenko(-5));
		assertEquals(-1, actual);
	}

	@Test
	void testZnamenkoIntNula() {

		int actual = (sg1.znamenko(0));
		assertEquals(0, actual);
	}

	@Test
	void testZnamenkoStrKladne() {

		double actual = (sg1.znamenko("8"));
		assertEquals(1, actual, DELTA);
	}

	@Test
	void testZnamenkoStrZaporne() {

		double actual = (sg1.znamenko("-8"));
		assertEquals(-1, actual, DELTA);
	}

	@Test
	void testZnamenkoStrNula() {
		double actual = (sg1.znamenko("0"));
		assertEquals(0, actual, DELTA);
	}

	@Test
	void testZnamenkoDesetinne() {
		Assertions.assertThrows(NumberFormatException.class, ()->{
		double actual = (sg1.znamenko("0.5"));
		});
	}
	
	@Test
	void testZnamenkoPismeno() {
		Assertions.assertThrows(NumberFormatException.class, ()->{
		double actual = (sg1.znamenko("a"));
		});
	}
	
}
