using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactList : MonoBehaviour {

	public GameObject buttonContainer;
	public ContactButton contactButton;
	public Contacts contactList;
	public Popup popup;

	void Start () {
		//foreach (tipoDeData cada_item in lista)
		foreach (ContactData item in contactList.contacts) {
			ContactButton newButton = Instantiate(contactButton);
			newButton.transform.SetParent (buttonContainer.transform);
			newButton.transform.localScale = Vector3.one;// es lo mismo a = new Vector3 (1, 1, 1);
			newButton.Init (item, popup);
		}
	}
}
