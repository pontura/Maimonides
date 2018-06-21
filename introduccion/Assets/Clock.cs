using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour {

	public float speed = 1;
	public float tick;

	public int sec;
	public float secFloated;
	public int min;
	public int hours;

	void Start () {
		sec = System.DateTime.Now.Second;
		min = System.DateTime.Now.Minute;
		hours = System.DateTime.Now.Hour;
	}

	void Update () {
		tick +=  Time.deltaTime * speed;
		if (tick > 1) {
			sec+=(int)Mathf.Round(tick);
			tick = 0;
		}
		if (sec >= 60) {
			sec = 0;
			min++;
		}
		if (min >= 60) {
			min = 0;
			hours++;
		}
		if (hours >= 24) {
			hours = 0;
		}
	}
}
