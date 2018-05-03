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


	void Start () {
		Close();
	}
	public void Init (ContactData data)
	{
		gameObject.SetActive (true);
		nameField.text = data.lastName + " " +  data.firstName;
		tel.text = data.celPhone.ToString();
		email.text = data.email;
		birthday.text = data.birthday;
		image.sprite = data.photo;
	}
	public void Close()
	{
		gameObject.SetActive (false);
	}
}
