using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour {
	public static int ProductsNumber = 0;
	public static int ProductsNumberItem = 0;

	Sprite Products;
	Image ProductsItem;
	GameObject ProductsItemGO,ProductsItemGO2,ProductsItemGO3;
	
	// Use this for initialization
	void Start () {
		Products = Resources.Load <Sprite> ("Sprites/ProductsItem/Vostro");
		ProductsItemGO = GameObject.Find ("ProductsItem");
		ProductsItemGO2 = GameObject.Find ("ProductsItem2");
		ProductsItemGO3 = GameObject.Find ("ProductsItem3");

		ProductsItem = GameObject.Find ("ProductsItem").GetComponent<Image>();
		ProductsItem.sprite = Products;

		MainController.ProductsNumberItem = 1;
		HideProducts();
	}
	
	// Update is called once per frame
	void Update () {
		

		if(ProductsNumber == 1){
			HideProducts();
			ProductsItemGO.SetActive(true);
		}else if(ProductsNumber == 2){
			HideProducts();
			ProductsItemGO2.SetActive(true);
		}else if(ProductsNumber == 3){
			HideProducts();
			ProductsItemGO3.SetActive(true);
		}
		
	}

	private void HideProducts(){
		ProductsItemGO.SetActive(false);
		ProductsItemGO2.SetActive(false);
		ProductsItemGO3.SetActive(false);
	}

	public void MenuFunction(string FuncName){
		if(FuncName == "ViewProducts"){ViewProducts();}

		if(FuncName == "Vostro"){Vostro();}
		if(FuncName == "OptiPlax"){OptiPlax();}
		if(FuncName == "DellPrecisionTowerWorkstations"){DellPrecisionTowerWorkstations();}
	}

	void ViewProducts(){
		print("ViewProducts");
		Application.LoadLevel("Scene_3_Producs");
	}

	void MenuSubHideAll(){
		MainController.ProductsNumber = 0;
	}

	void Vostro(){
		print("Vostro");
		MenuSubHideAll();
		MainController.ProductsNumber = 1;
		MainController.ProductsNumberItem = 1;
		MainMenu.isMenuProducts = false;
	}

	void OptiPlax(){
		print("OptiPlax");
		MenuSubHideAll();
		MainController.ProductsNumber = 2;
		MainController.ProductsNumberItem = 1;
		MainMenu.isMenuProducts = false;
	}

	void DellPrecisionTowerWorkstations(){
		print("DellPrecisionTowerWorkstations");
		MenuSubHideAll();
		MainController.ProductsNumber = 3;
		MainController.ProductsNumberItem = 1;
		MainMenu.isMenuProducts = false;
	}

	
}
