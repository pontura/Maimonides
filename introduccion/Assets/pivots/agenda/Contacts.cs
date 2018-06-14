using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contacts : MonoBehaviour {

	public List<ContactData> contacts;

	void Start () {
		DontDestroyOnLoad (this);
	}
}
