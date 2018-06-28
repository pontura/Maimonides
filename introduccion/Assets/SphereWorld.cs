using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereWorld : MonoBehaviour {

	public Clock clock;
	public int separation;
	public Animation anim_hours;
	public Animation anim_minutos;

	void Start () {
	}
	public float secondInAnimation;

	void Update()
	{
		float times = (((float)clock.hours * 60) + (float)clock.min) / 1440;
		anim_hours ["timer"].time = times*10;
		anim_hours.Play ("timer");

		times =  (((float)clock.min * 60) + (float)clock.sec) / 3600;
		anim_minutos ["timer"].time = times*10;
		anim_minutos.Play ("timer");
	}
}
