using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cafe : MonoBehaviour {

	public int temperature;

	void Update()
	{
		CheckLimits ();
	}
	public void CheckLimits()
	{
		if (temperature > 100)
			temperature = 100;
		else if (temperature < 0)
			temperature = 0;
	}
	public void ChangeTemperateValue(float value  )
	{
		temperature = (int)(temperature + value);
		if (temperature > 100)
			temperature = 100;
		else if (temperature < 0)
			temperature = 0;
	}
}
