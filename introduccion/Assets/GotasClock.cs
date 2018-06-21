using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotasClock : MonoBehaviour {

	public Clock clock;
	public AudioSource audioSource1;
	public AudioSource audioSource2;

	void Start()
	{
		Vector2 twoDigits = GetTwoDigits (clock.min);
		SaySound ((int)twoDigits.x, audioSource1, 0);
		SaySound ((int)twoDigits.y, audioSource2, 0.5f);
	}
	private Vector2 GetTwoDigits(int sec)
	{
		float firstDigit = Mathf.Floor ((float)sec / 10);
		float secondDigit = (((float)sec / 10) - firstDigit)*10;
		return new Vector2 (firstDigit, secondDigit);
	}
	public void OnClick()
	{
	}
	private void GetActualTime()
	{
	}
	private void SaySound(int num, AudioSource audioSource, float delay)
	{
		AudioClip clip = Resources.Load<AudioClip>("numeros/" + num);
		audioSource.clip = clip;
		audioSource.PlayDelayed(delay);
	}











	//	void Start () {
	//		TimeTick ();
	//	}
	//	void TimeTick()
	//	{
	//		sec++;
	//		if (sec > 12)
	//			sec = 0;
	//		Invoke("TimeTick", 1);
	//		LoadSound (sec);
	//	}
}
