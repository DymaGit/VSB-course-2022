package cz.vsb.austra.service;

import org.apache.tomcat.jni.Local;
import org.springframework.stereotype.Service;

import cz.vsb.austra.City;
import cz.vsb.austra.connector.WeatherStackConnector;
import cz.vsb.austra.dto.WeatherDto;
import cz.vsb.austra.dto.WeatherstackDto;

@Service
public class WeatherService {

	public WeatherDto getWeatherForCity(City cityEnum) {

		
		WeatherStackConnector connector = new WeatherStackConnector();
		WeatherstackDto weatherstackDto = connector.getWeatherForCity(cityEnum);

		return transformDto(weatherstackDto);
	}

	private WeatherDto transformDto(WeatherstackDto weatherstackDto) {
		WeatherDto wDto = new WeatherDto();
		wDto.setLocation(weatherstackDto.getLocation().getName());
		wDto.setRelative_humidity(weatherstackDto.getCurrent().getHumidity());
		wDto.setTemp_celsius(weatherstackDto.getCurrent().getTemperature());
		wDto.setTimeString(weatherstackDto.getLocation().getLocaltime());
		wDto.setWeather_description(weatherstackDto.getCurrent().getWeather_code());
		wDto.setWind_direction(weatherstackDto.getCurrent().getWind_dir());
		wDto.setWind_speed_m_per_s(weatherstackDto.getCurrent().getWind_speed());
	    
		return wDto;
	}
}
