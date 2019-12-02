using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductsController : MonoBehaviour {
	private GameObject ProductInfo_Vostro,ProductInfo_Vostro_270s,ProductInfo_Vostro_360,ProductInfo_Vostro_460,ProductInfo_Vostro_470;
	private GameObject ProductInfo_Optiplex,ProductInfo_Optiplex_3050,ProductInfo_Optiplex_3060,ProductInfo_Optiplex_3050AIO,ProductInfo_Optiplex_5050
	,ProductInfo_Optiplex_5055,ProductInfo_Optiplex_5060,ProductInfo_Optiplex_5250AIO,ProductInfo_Optiplex_5260AIO,ProductInfo_Optiplex_7050
	,ProductInfo_Optiplex_7060,ProductInfo_Optiplex_7450AIO,ProductInfo_Optiplex_7460AIO,ProductInfo_Optiplex_7760AIO,ProductInfo_Optiplex_XE2
	,ProductInfo_Optiplex_XE3;
	private GameObject ProductInfo_DellPrecisionTower, ProductInfo_DellPrecisionTower_3420,ProductInfo_DellPrecisionTower_R5500,ProductInfo_DellPrecisionTower_3620
	,ProductInfo_DellPrecisionTower_T5610,ProductInfo_DellPrecisionTower_5810,ProductInfo_DellPrecisionTower_7810,ProductInfo_DellPrecisionTower_7910Tower
	,ProductInfo_DellPrecisionTower_7910Rack;
	// Use this for initialization
	void Start () {

		ProductInfo_Vostro = GameObject.Find ("ProductInfo_Vostro");
		ProductInfo_Vostro_270s = GameObject.Find ("ProductInfo_Vostro_270s");
		ProductInfo_Vostro_360 = GameObject.Find ("ProductInfo_Vostro_360");
		ProductInfo_Vostro_460 = GameObject.Find ("ProductInfo_Vostro_460");
		ProductInfo_Vostro_470 = GameObject.Find ("ProductInfo_Vostro_470");

		ProductInfo_Optiplex = GameObject.Find ("ProductInfo_Optiplex");
		ProductInfo_Optiplex_3050 = GameObject.Find ("ProductInfo_Optiplex_3050");
		ProductInfo_Optiplex_3060 = GameObject.Find ("ProductInfo_Optiplex_3060");
		ProductInfo_Optiplex_3050AIO = GameObject.Find ("ProductInfo_Optiplex_3050AIO");
		ProductInfo_Optiplex_5050 = GameObject.Find ("ProductInfo_Optiplex_5050");
		ProductInfo_Optiplex_5055 = GameObject.Find ("ProductInfo_Optiplex_5055");
		ProductInfo_Optiplex_5060 = GameObject.Find ("ProductInfo_Optiplex_5060");
		ProductInfo_Optiplex_5250AIO = GameObject.Find ("ProductInfo_Optiplex_5250AIO");
		ProductInfo_Optiplex_5260AIO = GameObject.Find ("ProductInfo_Optiplex_5260AIO");
		ProductInfo_Optiplex_7050 = GameObject.Find ("ProductInfo_Optiplex_7050");
		ProductInfo_Optiplex_7060 = GameObject.Find ("ProductInfo_Optiplex_7060");
		ProductInfo_Optiplex_7450AIO = GameObject.Find ("ProductInfo_Optiplex_7450AIO");
		ProductInfo_Optiplex_7460AIO = GameObject.Find ("ProductInfo_Optiplex_7460AIO");
		ProductInfo_Optiplex_7760AIO = GameObject.Find ("ProductInfo_Optiplex_7760AIO");
		ProductInfo_Optiplex_XE2 = GameObject.Find ("ProductInfo_Optiplex_XE2");
		ProductInfo_Optiplex_XE3 = GameObject.Find ("ProductInfo_Optiplex_XE3");

		ProductInfo_DellPrecisionTower = GameObject.Find ("ProductInfo_DellPrecisionTower");
		ProductInfo_DellPrecisionTower_3420 = GameObject.Find ("ProductInfo_DellPrecisionTower_3420");
		ProductInfo_DellPrecisionTower_R5500 = GameObject.Find ("ProductInfo_DellPrecisionTower_R5500");
		ProductInfo_DellPrecisionTower_3620 = GameObject.Find ("ProductInfo_DellPrecisionTower_3620");
		ProductInfo_DellPrecisionTower_T5610 = GameObject.Find ("ProductInfo_DellPrecisionTower_T5610");
		ProductInfo_DellPrecisionTower_5810 = GameObject.Find ("ProductInfo_DellPrecisionTower_5810");
		ProductInfo_DellPrecisionTower_7810 = GameObject.Find ("ProductInfo_DellPrecisionTower_7810");
		ProductInfo_DellPrecisionTower_7910Tower = GameObject.Find ("ProductInfo_DellPrecisionTower_7910Tower");
		ProductInfo_DellPrecisionTower_7910Rack = GameObject.Find ("ProductInfo_DellPrecisionTower_7910Rack");
		
		SettingProducts();
	}

	private void SettingProducts(){
		HideAll();
		if(MainController.ProductsNumber == 1){
			ProductInfo_Vostro.SetActive(true);
			
			if(MainController.ProductsNumberItem == 1){
				ProductInfo_Vostro_270s.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 2){
				ProductInfo_Vostro_360.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 3){
				ProductInfo_Vostro_460.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 4){
				//ProductInfo_Vostro_460.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 5){
				ProductInfo_Vostro_470.SetActive(true);
			}
		}else if(MainController.ProductsNumber == 2){
			ProductInfo_Optiplex.SetActive(true);
			if(MainController.ProductsNumberItem == 1){
				ProductInfo_Optiplex_3050.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 2){
				ProductInfo_Optiplex_3060.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 3){
				ProductInfo_Optiplex_3050AIO.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 4){
				ProductInfo_Optiplex_5050.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 5){
				ProductInfo_Optiplex_5055.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 6){
				ProductInfo_Optiplex_5060.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 7){
				ProductInfo_Optiplex_5250AIO.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 8){
				ProductInfo_Optiplex_5260AIO.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 9){
				ProductInfo_Optiplex_7050.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 10){
				ProductInfo_Optiplex_7060.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 11){
				ProductInfo_Optiplex_7450AIO.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 12){
				ProductInfo_Optiplex_7460AIO.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 13){
				ProductInfo_Optiplex_7760AIO.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 14){
				ProductInfo_Optiplex_XE2.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 15){
				ProductInfo_Optiplex_XE3.SetActive(true);
			}
		}else if(MainController.ProductsNumber == 3){
			ProductInfo_DellPrecisionTower.SetActive(true);
			if(MainController.ProductsNumberItem == 1){
				ProductInfo_DellPrecisionTower_R5500.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 2){
				ProductInfo_DellPrecisionTower_3420.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 3){
				ProductInfo_DellPrecisionTower_3620.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 4){
				ProductInfo_DellPrecisionTower_T5610.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 5){
				ProductInfo_DellPrecisionTower_5810.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 6){
				ProductInfo_DellPrecisionTower_7810.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 7){
				ProductInfo_DellPrecisionTower_7910Tower.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 8){
				ProductInfo_DellPrecisionTower_7910Rack.SetActive(true);
			}

		}
	}

	private void HideAll(){
		ProductInfo_Vostro.SetActive(false);
		ProductInfo_Vostro_270s.SetActive(false);
		ProductInfo_Vostro_360.SetActive(false);
		ProductInfo_Vostro_460.SetActive(false);
		ProductInfo_Vostro_470.SetActive(false);

		ProductInfo_Optiplex.SetActive(false);
		ProductInfo_Optiplex_3050.SetActive(false);
		ProductInfo_Optiplex_3060.SetActive(false);
		ProductInfo_Optiplex_3050AIO.SetActive(false);
		ProductInfo_Optiplex_5050.SetActive(false);
		ProductInfo_Optiplex_5055.SetActive(false);
		ProductInfo_Optiplex_5060.SetActive(false);
		ProductInfo_Optiplex_5250AIO.SetActive(false);
		ProductInfo_Optiplex_5260AIO.SetActive(false);
		ProductInfo_Optiplex_7050.SetActive(false);
		ProductInfo_Optiplex_7060.SetActive(false);
		ProductInfo_Optiplex_7450AIO.SetActive(false);
		ProductInfo_Optiplex_7460AIO.SetActive(false);
		ProductInfo_Optiplex_7760AIO.SetActive(false);
		ProductInfo_Optiplex_XE2.SetActive(false);
		ProductInfo_Optiplex_XE3.SetActive(false);

		ProductInfo_DellPrecisionTower.SetActive(false);
		ProductInfo_DellPrecisionTower_3420.SetActive(false);
		ProductInfo_DellPrecisionTower_R5500.SetActive(false);
		ProductInfo_DellPrecisionTower_3620.SetActive(false);
		ProductInfo_DellPrecisionTower_T5610.SetActive(false);
		ProductInfo_DellPrecisionTower_5810.SetActive(false);
		ProductInfo_DellPrecisionTower_7810.SetActive(false);
		ProductInfo_DellPrecisionTower_7910Tower.SetActive(false);
		ProductInfo_DellPrecisionTower_7910Rack.SetActive(false);
	}

	public void ChangeProductItem(int ProductItem){
		MainController.ProductsNumberItem = ProductItem;
		MainMenu.isMenuProducts = false;
		SettingProducts();
	}
}
