package cz.vsb.austra.controller;

import java.util.ArrayList;
import java.util.Collection;
import java.util.List;

import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.fasterxml.jackson.databind.util.ClassUtil.Ctor;

import cz.vsb.austra.City;

import cz.vsb.austra.dto.WeatherDto;
import cz.vsb.austra.service.WeatherService;

@RestController
public class WeatherController {
	private WeatherService weatherService;

	public WeatherController() {
		weatherService = new WeatherService();

	}

	@CrossOrigin
	@RequestMapping("/weather")

	public Collection<WeatherDto> getWeather() {
		List<WeatherDto> weatherList = new ArrayList<>();
		// WeatherService weatherService = new WeatherService();

		for (City city : City.values()) {
			WeatherDto weatherDto = weatherService.getWeatherForCity(city);
			weatherList.add(weatherDto);
		}
		return weatherList;
	}

	@CrossOrigin
	@RequestMapping("/weather/{city}")
	public WeatherDto getWeatherForCity(@PathVariable String city) {
		City cityEnum = City.valueOf(city.toUpperCase());
		// WeatherService weatherService = new WeatherService();
		return weatherService.getWeatherForCity(cityEnum);
	}
}
