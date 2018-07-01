using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveAndChange : MonoBehaviour {

	public void ChangeAndSave(){
		PlayerPrefs.SetInt ("Pedang Jenawi Copper", Inventory.Item[0]);
		PlayerPrefs.SetInt ("Pedang Jenawi Gold", Inventory.Item[1]);
		PlayerPrefs.SetInt ("Pedang Jenawi Iron", Inventory.Item[2]);
		PlayerPrefs.SetInt ("Pedang Jenawi Silver", Inventory.Item[3]);
		PlayerPrefs.SetInt ("Pedang Jenawi Steel",Inventory.Item[4]);
		PlayerPrefs.SetInt ("Siwar Panjang Copper", Inventory.Item[5]);
		PlayerPrefs.SetInt ("Siwar Panjang Gold", Inventory.Item[6]);
		PlayerPrefs.SetInt ("Siwar Panjang Iron", Inventory.Item[7]);
		PlayerPrefs.SetInt ("Siwar Panjang Silver", Inventory.Item[8]);
		PlayerPrefs.SetInt ("Siwar Panjang Steel", Inventory.Item[9]);
		PlayerPrefs.SetInt ("Trisula Copper", Inventory.Item[10]);
		PlayerPrefs.SetInt ("Trisula Gold", Inventory.Item[11]);
		PlayerPrefs.SetInt ("Trisula Iron", Inventory.Item[12]);
		PlayerPrefs.SetInt ("Trisula Silver", Inventory.Item[13]);
		PlayerPrefs.SetInt ("Trisula Steel", Inventory.Item[14]);
		PlayerPrefs.SetInt ("Golok Copper", Inventory.Item[15]);
		PlayerPrefs.SetInt ("Golok Gold", Inventory.Item[16]);
		PlayerPrefs.SetInt ("Golok Iron", Inventory.Item[17]);
		PlayerPrefs.SetInt ("Golok Silver", Inventory.Item[18]);
		PlayerPrefs.SetInt ("Golok Steel", Inventory.Item[19]);
		SceneManager.LoadScene ("S1");
	}
}
