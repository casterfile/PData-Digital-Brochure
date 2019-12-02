using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactUs : MonoBehaviour {
	public GameObject ContactUs_1, ContactUs_2;
	// Use this for initialization
	void Start () {
		ContactUs_1.SetActive(true);
		ContactUs_2.SetActive(false);
	}
	
	// Update is called once per frame
	public void PressAction (string Data) {
		MainMenu.isMenuProducts = false;
		if(Data == "ContactUs_1"){
			ContactUs_1.SetActive(true);
			ContactUs_2.SetActive(false);
		}else{
			ContactUs_1.SetActive(false);
			ContactUs_2.SetActive(true);
		}
	}
}
