using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
	GameObject MoreInfo;
	public static bool isMenuProducts;

	// Use this for initialization
	void Start () {
		MoreInfo =  GameObject.Find ("MoreInfo");
		MoreInfo.SetActive(false);
		isMenuProducts = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(isMenuProducts == true){
			MoreInfo.SetActive(true);
		}else{
			MoreInfo.SetActive(false);
		}
	}

	public void MenuFunction(string FuncName){
		MenuMainHideAll();
		if(FuncName == "MenuProducts"){MenuProducts();}
		if(FuncName == "MenuAbout"){MenuAbout();}
		if(FuncName == "MenuContactUs"){MenuContactUs();}

		if(FuncName == "Vostro"){Vostro();}
		if(FuncName == "OptiPlax"){OptiPlax();}
		if(FuncName == "DellPrecisionTowerWorkstations"){DellPrecisionTowerWorkstations();}
	}

	void MenuProducts(){
		if(isMenuProducts == true){
			isMenuProducts = false;
			MoreInfo.SetActive(false);
			print("isMenuProducts2: "+isMenuProducts);
		}else if(isMenuProducts == false){
			isMenuProducts = true;
			MoreInfo.SetActive(true);
			print("isMenuProducts1: "+isMenuProducts);
		}
	}

	void MenuAbout(){
		Application.LoadLevel("Scene_2_AboutUs");
		isMenuProducts = false;
	}

	void MenuContactUs(){
		isMenuProducts = false;
		Application.LoadLevel("Scene_2_ContactUs");
	}

	void MenuMainHideAll(){
		MoreInfo.SetActive(false);
		
	}


	void MenuSubHideAll(){
		MainController.ProductsNumber = 0;
		MainController.ProductsNumberItem = 1;
		MainMenu.isMenuProducts = false;
	}

	void Vostro(){
		MenuSubHideAll();
		MainController.ProductsNumber = 1;
		MainController.ProductsNumberItem = 1;
		MainMenu.isMenuProducts = false;
		GoProducts();
	}

	void OptiPlax(){
		MenuSubHideAll();
		MainController.ProductsNumber = 2;
		MainController.ProductsNumberItem = 1;
		MainMenu.isMenuProducts = false;
		GoProducts();
	}

	void DellPrecisionTowerWorkstations(){
		MenuSubHideAll();
		MainController.ProductsNumber = 3;
		MainController.ProductsNumberItem = 1;
		MainMenu.isMenuProducts = false;
		GoProducts();
	}

	void GoProducts(){
		string SceneName = "Scene_3_Producs";
		Application.LoadLevel(SceneName);
	}
}
