using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpectController : MonoBehaviour {
	private GameObject ProductInfo_Vostro_270s,ProductInfo_Vostro_360,ProductInfo_Vostro_460,ProductInfo_Vostro_470;
	private GameObject ProductInfo_Optiplex_3050,ProductInfo_Optiplex_3060,ProductInfo_Optiplex_3050AIO,ProductInfo_Optiplex_5050
	,ProductInfo_Optiplex_5055,ProductInfo_Optiplex_5060,ProductInfo_Optiplex_5250AIO,ProductInfo_Optiplex_5260AIO,ProductInfo_Optiplex_7050
	,ProductInfo_Optiplex_7060,ProductInfo_Optiplex_7450AIO,ProductInfo_Optiplex_7460AIO,ProductInfo_Optiplex_7760AIO,ProductInfo_Optiplex_XE2
	,ProductInfo_Optiplex_XE3;
	private GameObject ProductInfo_DellPrecisionTower_3420,ProductInfo_DellPrecisionTower_R5500,ProductInfo_DellPrecisionTower_3620
	,ProductInfo_DellPrecisionTower_T5610,ProductInfo_DellPrecisionTower_5810,ProductInfo_DellPrecisionTower_7810,ProductInfo_DellPrecisionTower_7910Tower
	,ProductInfo_DellPrecisionTower_7910Rack;
	private GameObject ButtonControl ,GONext,GOPrev,CircleController1,CircleController2,PictureProduct1,PictureProduct2;
	private int PictureCount = 1, PictureCountLimit = 0;
	// Use this for initialization
	void Start () {
		
		ProductInfo_Vostro_270s = GameObject.Find ("ProductInfo_Vostro_270s");
		ProductInfo_Vostro_360 = GameObject.Find ("ProductInfo_Vostro_360");
		ProductInfo_Vostro_460 = GameObject.Find ("ProductInfo_Vostro_460");
		ProductInfo_Vostro_470 = GameObject.Find ("ProductInfo_Vostro_470");

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

		ProductInfo_DellPrecisionTower_3420 = GameObject.Find ("ProductInfo_DellPrecisionTower_3420");
		ProductInfo_DellPrecisionTower_R5500 = GameObject.Find ("ProductInfo_DellPrecisionTower_R5500");
		ProductInfo_DellPrecisionTower_3620 = GameObject.Find ("ProductInfo_DellPrecisionTower_3620");
		ProductInfo_DellPrecisionTower_T5610 = GameObject.Find ("ProductInfo_DellPrecisionTower_T5610");
		ProductInfo_DellPrecisionTower_5810 = GameObject.Find ("ProductInfo_DellPrecisionTower_5810");
		ProductInfo_DellPrecisionTower_7810 = GameObject.Find ("ProductInfo_DellPrecisionTower_7810");
		ProductInfo_DellPrecisionTower_7910Tower = GameObject.Find ("ProductInfo_DellPrecisionTower_7910Tower");
		ProductInfo_DellPrecisionTower_7910Rack = GameObject.Find ("ProductInfo_DellPrecisionTower_7910Rack");
		HideAll();
		if(MainController.ProductsNumber == 1){
			
			if(MainController.ProductsNumberItem == 1){
				PictureCountLimit = 2;
				ProductInfo_Vostro_270s.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 2){
				PictureCountLimit = 2;
				ProductInfo_Vostro_360.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 3){
				PictureCountLimit = 2;
				ProductInfo_Vostro_460.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 5){
				PictureCountLimit = 1;
				ProductInfo_Vostro_470.SetActive(true);
			}
		}else if(MainController.ProductsNumber == 2){
			
			if(MainController.ProductsNumberItem == 1){
				PictureCountLimit = 2;
				ProductInfo_Optiplex_3050.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 2){
				PictureCountLimit = 2;
				ProductInfo_Optiplex_3060.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 3){
				PictureCountLimit = 2;
				ProductInfo_Optiplex_3050AIO.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 4){
				PictureCountLimit = 2;
				ProductInfo_Optiplex_5050.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 5){
				PictureCountLimit = 2;
				ProductInfo_Optiplex_5055.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 6){
				PictureCountLimit = 2;
				ProductInfo_Optiplex_5060.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 7){
				PictureCountLimit = 2;
				ProductInfo_Optiplex_5250AIO.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 8){
				PictureCountLimit = 2;
				ProductInfo_Optiplex_5260AIO.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 9){
				PictureCountLimit = 1;
				ProductInfo_Optiplex_7050.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 10){
				PictureCountLimit = 2;
				ProductInfo_Optiplex_7060.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 11){
				PictureCountLimit = 2;
				ProductInfo_Optiplex_7450AIO.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 12){
				PictureCountLimit = 2;
				ProductInfo_Optiplex_7460AIO.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 13){
				PictureCountLimit = 2;
				ProductInfo_Optiplex_7760AIO.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 14){
				PictureCountLimit = 2;
				ProductInfo_Optiplex_XE2.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 15){
				PictureCountLimit = 2;
				ProductInfo_Optiplex_XE3.SetActive(true);
			}
		}else if(MainController.ProductsNumber == 3){
			if(MainController.ProductsNumberItem == 1){
				PictureCountLimit = 2;
				ProductInfo_DellPrecisionTower_R5500.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 2){
				PictureCountLimit = 1;
				ProductInfo_DellPrecisionTower_3420.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 3){
				PictureCountLimit = 2;
				ProductInfo_DellPrecisionTower_3620.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 4){
				PictureCountLimit = 1;
				ProductInfo_DellPrecisionTower_T5610.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 5){
				PictureCountLimit = 1;
				ProductInfo_DellPrecisionTower_5810.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 6){
				PictureCountLimit = 1;
				ProductInfo_DellPrecisionTower_7810.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 7){
				PictureCountLimit = 1;
				ProductInfo_DellPrecisionTower_7910Tower.SetActive(true);
			}
			if(MainController.ProductsNumberItem == 8){
				PictureCountLimit = 2;
				ProductInfo_DellPrecisionTower_7910Rack.SetActive(true);
			}

		}

		ButtonControl = GameObject.Find ("ButtonController");
		GONext = GameObject.Find ("GONext");
		GOPrev = GameObject.Find ("GOPrev");

		CircleController1 = GameObject.Find ("Circle/CircleOn");
		CircleController2 = GameObject.Find ("Circle (1)/CircleOn");

		PictureProduct1 = GameObject.Find ("PictureProduct (1)");
		PictureProduct2 = GameObject.Find ("PictureProduct (2)");


		if(PictureCountLimit > 1){
			ButtonControl.SetActive(true);
			
			GONext.SetActive(true);
			GOPrev.SetActive(false);
			CircleController1.SetActive(true);
			CircleController2.SetActive(false);
			PictureProduct1.SetActive(true);
			PictureProduct2.SetActive(false);
		}else{
			ButtonControl.SetActive(false);
		}
	}

	private void HideAll(){
		ProductInfo_Vostro_270s.SetActive(false);
		ProductInfo_Vostro_360.SetActive(false);
		ProductInfo_Vostro_460.SetActive(false);
		ProductInfo_Vostro_470.SetActive(false);

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

		ProductInfo_DellPrecisionTower_3420.SetActive(false);
		ProductInfo_DellPrecisionTower_R5500.SetActive(false);
		ProductInfo_DellPrecisionTower_3620.SetActive(false);
		ProductInfo_DellPrecisionTower_T5610.SetActive(false);
		ProductInfo_DellPrecisionTower_5810.SetActive(false);
		ProductInfo_DellPrecisionTower_7810.SetActive(false);
		ProductInfo_DellPrecisionTower_7910Tower.SetActive(false);
		ProductInfo_DellPrecisionTower_7910Rack.SetActive(false);
	}

	public void FuncNext(){
		GONext.SetActive(false);
		GOPrev.SetActive(true);
		CircleController1.SetActive(false);
		CircleController2.SetActive(true);
		PictureProduct1.SetActive(false);
		PictureProduct2.SetActive(true);
	}
	public void FuncPrev(){
		GONext.SetActive(true);
		GOPrev.SetActive(false);
		CircleController1.SetActive(true);
		CircleController2.SetActive(false);
		PictureProduct1.SetActive(true);
		PictureProduct2.SetActive(false);
	}
}

//ProductInfo_Optiplex_7460AIO Picture Products
//ProductInfo_Optiplex_XE2, ProductInfo_Optiplex_XE3 No title

//5060, 5260AIO  Title Wrong