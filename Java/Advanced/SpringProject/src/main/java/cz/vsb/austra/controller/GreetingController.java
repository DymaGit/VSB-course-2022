package cz.vsb.austra.controller;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class GreetingController {
	
	@RequestMapping("/hello")
	String hello() {
		return "Hello world!!";
	}
	
	@RequestMapping("/hello2")
	String hello2() {
		return "Hello world 2!!";
	}
}
