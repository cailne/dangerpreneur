using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HitBoxTEMP : MonoBehaviour {

	MasterSceneChange gochange;
	public Canvas chooseMaterial;
	
	void Start(){
		gochange = GameObject.Find("SceneChangepls").GetComponent<MasterSceneChange>();
	}

	void OnMouseDown(){
		//gochange.ToCrafting2Complete();

		//JADI PAS DIA PILIH SENJATA, KITA LANGSUNG SET WEAPON ID NYA TERGANTUNG PILIHAN
		// ABIS ITU NONGOL POPUP PILIH MATERIAL. LIAT SCRIPT PIckMaterial.cs
		// DISITU KITA SET MATERIAL ID TRS GO KE SCENE CRAFTING CONFIRMATION (YG ADA ACCEPT SAMA DECLINE)
		// DI SCENE ITU KITA NENTUIN GAMBAR MANA YANG DITUNJUKKIN BERDASARKAN WEAPON ID SAMA MATERIAL ID 

		//POP UP MATERIAL CHOICES
		if (chooseMaterial.gameObject.activeInHierarchy == false) {
			chooseMaterial.gameObject.SetActive (true);
		} else {
			chooseMaterial.gameObject.SetActive(false);
		}

		switch (gameObject.name) {
		case "Jenawi":
			PlayerPrefs.SetInt ("WeaponID", 1);
			break;
		}
	}



}
