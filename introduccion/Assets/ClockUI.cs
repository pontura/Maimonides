using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockUI : MonoBehaviour {

	public Text field;
	public Clock clock;
	public Slider sliderSpeed;
	public Slider sliderHour;
	public Image noche;
	public Light redLight;
	public Light blueLight;
	public Light greenLight;

	void Update () {
		ShowTime();
		ChangeAlpha ();
	}
	public void ChangeSpeed()
	{
		clock.speed = sliderSpeed.value;
	}
	public void ChangeHour()
	{
		clock.hours = (int)sliderHour.value;
	}
	void ShowTime()
	{
		field.text = AddZero(clock.hours) + ":" + AddZero(clock.min) + ":" + AddZero(clock.sec);
	}
	void ChangeAlpha()
	{
		float normalizedHour = Mathf.Abs(((float)(clock.min+(clock.hours*60))-720)/720);
		Color color = noche.color;
		color.a = normalizedHour;
		noche.color = color;

		color = redLight.color;
		color.r = normalizedHour;
		color.g = 0;
		color.b = 0.5f;
		redLight.color = color;

		color = blueLight.color;
		color.b = normalizedHour;
		color.g = 0;
		color.r = 0.5f;
		blueLight.color = color;

		color = greenLight.color;
		color.g = normalizedHour;
		color.r = 0;
		color.b = 0.5f;
		greenLight.color = color;
	}
	string AddZero(int value)
	{		
		string str = value.ToString ();
		if (value < 10) {
			str = "0" + str;
		}
		return str;
	}
}
