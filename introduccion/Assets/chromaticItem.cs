using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chromaticItem : MonoBehaviour {

	public Image image;
	 

	public void Init (int second) {

		HSBColor newColor = new HSBColor (image.color);

		float valueColor = ChangeSecondsToHue (second);
		print (valueColor);
		newColor.h = valueColor;
		image.color = newColor.ToColor();
	}

	float ChangeSecondsToHue (int second) {

		float hueValue;


		hueValue = second / (float)60;

		return hueValue;


	}
}
