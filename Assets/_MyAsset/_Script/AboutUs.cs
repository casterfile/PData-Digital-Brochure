using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutUs : MonoBehaviour {
	private GameObject AboutUs_1, AboutUs_2,AboutUs_3,AboutUs_4,AboutUs_5,AboutUs_6,AboutUs_7,AboutUs_8,AboutUs_9
	,AboutUs_10,AboutUs_11;
	int Count = 1;
	bool isPress = false;
	// Use this for initialization
	void Start () {
		Count = 1;
		isPress = false;

		AboutUs_1 =  GameObject.Find ("AboutUs_1");
		AboutUs_2 =  GameObject.Find ("AboutUs_2");
		AboutUs_3 =  GameObject.Find ("AboutUs_3");
		AboutUs_4 =  GameObject.Find ("AboutUs_4");
		AboutUs_5 =  GameObject.Find ("AboutUs_5");
		AboutUs_6 =  GameObject.Find ("AboutUs_6");
		AboutUs_7 =  GameObject.Find ("AboutUs_7");
		AboutUs_8 =  GameObject.Find ("AboutUs_8");
		AboutUs_9 =  GameObject.Find ("AboutUs_9");
		AboutUs_10 =  GameObject.Find ("AboutUs_10");
		AboutUs_11 =  GameObject.Find ("AboutUs_11");

		AboutUs_1.SetActive(true);
		AboutUs_2.SetActive(false);
		AboutUs_3.SetActive(false);
		AboutUs_4.SetActive(false);
		AboutUs_5.SetActive(false);
		AboutUs_6.SetActive(false);
		AboutUs_7.SetActive(false);
		AboutUs_8.SetActive(false);
		AboutUs_9.SetActive(false);
		AboutUs_10.SetActive(false);
		AboutUs_11.SetActive(false);
	}

	void Update(){
		if(Count < 1){
    		Count = 11;
    	}
    	if(Count > 11){
    		Count = 1;
    	}
	}

	public void NextPressRunNow(){
		StartCoroutine(RunNowNext());
	}
	public void PrevPressRunNow(){
		StartCoroutine(RunNowPrev());
	}

	IEnumerator RunNowNext()
    {
    	if(isPress == true){
    		yield return null;
    	}
    	isPress = true;
    	Count++;
    	if(Count == 1){
    		HideAll();
    		AboutUs_1.SetActive(true);
    	}
    	if(Count == 2){
    		HideAll();
    		AboutUs_2.SetActive(true);
    	}
    	if(Count == 3){
    		HideAll();
    		AboutUs_3.SetActive(true);
    	}
    	if(Count == 4){
    		HideAll();
    		AboutUs_4.SetActive(true);
    	}
    	if(Count == 5){
    		HideAll();
    		AboutUs_5.SetActive(true);
    	}
    	if(Count == 6){
    		HideAll();
    		AboutUs_6.SetActive(true);
    	}
    	if(Count == 7){
    		HideAll();
    		AboutUs_7.SetActive(true);
    	}
    	if(Count == 8){
    		HideAll();
    		AboutUs_8.SetActive(true);
    	}
    	if(Count == 9){
    		HideAll();
    		AboutUs_9.SetActive(true);
    	}
    	if(Count == 10){
    		HideAll();
    		AboutUs_10.SetActive(true);
    	}
    	if(Count == 11){
    		HideAll();
    		AboutUs_11.SetActive(true);
    		Count = 1;
    	}
    	yield return new WaitForSeconds(1.0f);
    	isPress = false;

    }

    IEnumerator RunNowPrev()
    {
    	if(isPress == true){
    		yield return null;
    	}
    	isPress = true;
    	Count--;
    	if(Count < 1){
			Count = 11;
    	}
    	if(Count == 1){
    		HideAll();
    		AboutUs_1.SetActive(true);
    	}
    	if(Count == 2){
    		HideAll();
    		AboutUs_2.SetActive(true);
    	}
    	if(Count == 3){
    		HideAll();
    		AboutUs_3.SetActive(true);
    	}
    	if(Count == 4){
    		HideAll();
    		AboutUs_4.SetActive(true);
    	}
    	if(Count == 5){
    		HideAll();
    		AboutUs_5.SetActive(true);
    	}
    	if(Count == 6){
    		HideAll();
    		AboutUs_6.SetActive(true);
    	}
    	if(Count == 7){
    		HideAll();
    		AboutUs_7.SetActive(true);
    	}
    	if(Count == 8){
    		HideAll();
    		AboutUs_8.SetActive(true);
    	}
    	if(Count == 9){
    		HideAll();
    		AboutUs_9.SetActive(true);
    	}
    	if(Count == 10){
    		HideAll();
    		AboutUs_10.SetActive(true);
    	}
    	if(Count == 11){
    		HideAll();
    		AboutUs_11.SetActive(true);
    		
    	}
    	yield return new WaitForSeconds(1.0f);
    	isPress = false;

    }

	private void HideAll(){
		MainMenu.isMenuProducts = false;
		AboutUs_1.SetActive(false);
		AboutUs_2.SetActive(false);
		AboutUs_3.SetActive(false);
		AboutUs_4.SetActive(false);
		AboutUs_5.SetActive(false);
		AboutUs_6.SetActive(false);
		AboutUs_7.SetActive(false);
		AboutUs_8.SetActive(false);
		AboutUs_9.SetActive(false);
		AboutUs_10.SetActive(false);
		AboutUs_11.SetActive(false);
	}
}
