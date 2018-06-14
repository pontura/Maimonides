using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChromaticClock : MonoBehaviour {
	
	public Clock clock;
	public Text field;
	public Slider sliderSpeed;
	public Slider sliderHour;
	public Image secondImg;
	public float value;
	public chromaticItem item;
	public Transform container;


	void Start (){
	
		ShowChromatic ();
	
	}

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
		field.text = clock.sec.ToString();
		Color secondImgColor = secondImg.color;
		HSBColor newColor = new HSBColor (secondImgColor);

		value = ChangeSecondsToHue (clock.sec);

		newColor.h = value;
		secondImg.color = newColor.ToColor();
	}

	float ChangeSecondsToHue (int second) {

		float hueValue;


		hueValue = second / (float)60;

		return hueValue;


	}

	void ShowChromatic (){

		for (int i = 0; i < 60; i++) {

			chromaticItem newItem = Instantiate (item);

			//setear a un empty como padre para tener organizado y poder modificar todo
			newItem.transform.SetParent (container);
			newItem.transform.localPosition = Vector3.zero;
			newItem.transform.localEulerAngles = new Vector3(0,0,i*360/60);

			newItem.Init (i);
		}
	}

}
