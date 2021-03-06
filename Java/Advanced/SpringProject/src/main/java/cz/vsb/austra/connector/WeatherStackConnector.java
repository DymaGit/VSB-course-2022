package cz.vsb.austra.connector;

import java.net.URI;
import java.net.URISyntaxException;

import org.springframework.http.ResponseEntity;
import org.springframework.web.client.RestTemplate;

import cz.vsb.austra.City;

public class WeatherStackConnector {
	// http://api.weatherstack.com/current?access_key=054b12500b828088e2269ce0725b10c9&query=New%20York
	private static String baseURL = "http://api.weatherstack.com/";
	private static String urlParamString = "current?access_key=";
	private static String APIkey = "054b12500b828088e2269ce0725b10c9";
	private static String url = baseURL + urlParamString + APIkey + "&query=";

	public String getWeatherForCity(City cityEnum) {
		RestTemplate template = new RestTemplate();

		URI uri = null;
		try {
			uri = new URI(url + cityEnum);

		} catch (URISyntaxException e) {
			e.printStackTrace();
		}

		ResponseEntity<String> response = template.getForEntity(uri, String.class);
		return response.getBody();

	}

}
