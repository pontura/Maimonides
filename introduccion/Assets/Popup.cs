using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popup : MonoBehaviour {

	//1 empezar hidden
	//2 aparecer
	//3 imprime datos
	//cerrar
	public Text nameField;
	public Text email;
	public Text tel;
	public Text birthday;
	public Image image;

	public Animation anim;	

	void Start () {
		TurnOff();
	}
	public void Init (ContactData data)
	{
		gameObject.SetActive (true);
		anim.Play ("openPopup");
		nameField.text = data.lastName + " " +  data.firstName;
		tel.text = data.celPhone.ToString();
		email.text = data.email;
		birthday.text = data.birthday;
		image.sprite = data.photo;
	}
	public void Close()
	{
		print ("Close");
		anim.Play ("closePopup");
		Invoke ("TurnOff", 0.5f);
	}
	public void TurnOff()
	{
		gameObject.SetActive (false);
	}
}
