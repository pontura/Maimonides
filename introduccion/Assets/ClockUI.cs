using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockUI : MonoBehaviour {

	public Text field;
	public Clock clock;
	public Slider sliderSpeed;
	public Slider sliderHour;

	void Update () {
		ShowTime();
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
	string AddZero(int value)
	{		
		string str = value.ToString ();
		if (value < 10) {
			str = "0" + str;
		}
		return str;
	}
}
