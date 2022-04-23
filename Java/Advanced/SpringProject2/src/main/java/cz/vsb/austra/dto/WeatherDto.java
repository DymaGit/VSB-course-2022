package cz.vsb.austra.dto;

public class WeatherDto {

	private String location;
	private String timeString;
	private float temp_celsius;
	private float relative_humidity;
	private float wind_speed_m_per_s;
	private String wind_direction;
	private String weather_description;
	
	
	public String getLocation() {
		return location;
	}
	public void setLocation(String location) {
		this.location = location;
	}
	public String getTimeString() {
		return timeString;
	}
	public void setTimeString(String timeString) {
		this.timeString = timeString;
	}
	public float getTemp_celsius() {
		return temp_celsius;
	}
	public void setTemp_celsius(float temp_celsius) {
		this.temp_celsius = temp_celsius;
	}
	public float getRelative_humidity() {
		return relative_humidity;
	}
	public void setRelative_humidity(float relative_humidity) {
		this.relative_humidity = relative_humidity;
	}
	public float getWind_speed_m_per_s() {
		return wind_speed_m_per_s;
	}
	public void setWind_speed_m_per_s(float wind_speed_m_per_s) {
		this.wind_speed_m_per_s = wind_speed_m_per_s;
	}
	public String getWind_direction() {
		return wind_direction;
	}
	public void setWind_direction(String wind_direction) {
		this.wind_direction = wind_direction;
	}
	public String getWeather_description() {
		return weather_description;
	}
	public void setWeather_description(String weather_description) {
		this.weather_description = weather_description;
	}
	
}
