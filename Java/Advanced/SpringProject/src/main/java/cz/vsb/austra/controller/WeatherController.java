package cz.vsb.austra.controller;

import javax.websocket.server.PathParam;

import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import cz.vsb.austra.City;
import cz.vsb.austra.connector.WeatherStackConnector;

@RestController
public class WeatherController {

	@RequestMapping("/weather")
	public String getWeather() {
		return "Počasí všechny města";
	}

	@RequestMapping("/weather/{city}")
	public String getWeatherForCity(@PathVariable String city) {
	
		City cityEnum = City.valueOf(city.toUpperCase());
		
		WeatherStackConnector connector = new WeatherStackConnector();
		return connector.getWeatherForCity(cityEnum);
	}
}
