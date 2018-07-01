using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public static int[] Item = new int[20];
	void Start(){
		if (PlayerPrefs.GetInt ("Pedang Jenawi", 0) > 0) {
			Inventory.Item [0] = PlayerPrefs.GetInt ("Pedang Jenawi Copper", 0);
			Inventory.Item [1] = PlayerPrefs.GetInt ("Pedang Jenawi Gold", 0);
			Inventory.Item [2] = PlayerPrefs.GetInt ("Pedang Jenawi Iron", 0);
			Inventory.Item [3] = PlayerPrefs.GetInt ("Pedang Jenawi Silver", 0);
			Inventory.Item [4] = PlayerPrefs.GetInt ("Pedang Jenawi Steel", 0);
			Inventory.Item [5] = PlayerPrefs.GetInt ("Siwar Panjang Copper", 0);
			Inventory.Item [6] = PlayerPrefs.GetInt ("Siwar Panjang Gold", 0);
			Inventory.Item [7] = PlayerPrefs.GetInt ("Siwar Panjang Iron", 0);
			Inventory.Item [8] = PlayerPrefs.GetInt ("Siwar Panjang Silver", 0);
			Inventory.Item [9] = PlayerPrefs.GetInt ("Siwar Panjang Steel", 0);
			Inventory.Item [10] = PlayerPrefs.GetInt ("Trisula Copper", 0);
			Inventory.Item [11] = PlayerPrefs.GetInt ("Trisula Gold", 0);
			Inventory.Item [12] = PlayerPrefs.GetInt ("Trisula Iron", 0);
			Inventory.Item [13] = PlayerPrefs.GetInt ("Trisula Silver", 0);
			Inventory.Item [14] = PlayerPrefs.GetInt ("Trisula Steel", 0);
			Inventory.Item [15] = PlayerPrefs.GetInt ("Golok Copper", 0);
			Inventory.Item [16] = PlayerPrefs.GetInt ("Golok Gold", 0);
			Inventory.Item [17] = PlayerPrefs.GetInt ("Golok Iron", 0);
			Inventory.Item [18] = PlayerPrefs.GetInt ("Golok Silver", 0);
			Inventory.Item [19] = PlayerPrefs.GetInt ("Golok Steel", 0);
		} else {
			PlayerPrefs.SetInt ("Pedang Jenawi Copper", 0);
			PlayerPrefs.SetInt ("Pedang Jenawi Gold", 0);
			PlayerPrefs.SetInt ("Pedang Jenawi Iron", 0);
			PlayerPrefs.SetInt ("Pedang Jenawi Silver", 0);
			PlayerPrefs.SetInt ("Pedang Jenawi Steel", 0);
			PlayerPrefs.SetInt ("Siwar Panjang Copper", 0);
			PlayerPrefs.SetInt ("Siwar Panjang Gold", 0);
			PlayerPrefs.SetInt ("Siwar Panjang Iron", 0);
			PlayerPrefs.SetInt ("Siwar Panjang Silver", 0);
			PlayerPrefs.SetInt ("Siwar Panjang Steel", 0);
			PlayerPrefs.SetInt ("Trisula Copper", 0);
			PlayerPrefs.SetInt ("Trisula Gold", 0);
			PlayerPrefs.SetInt ("Trisula Iron", 0);
			PlayerPrefs.SetInt ("Trisula Silver", 0);
			PlayerPrefs.SetInt ("Trisula Steel", 0);
			PlayerPrefs.SetInt ("Golok Copper", 0);
			PlayerPrefs.SetInt ("Golok Gold", 0);
			PlayerPrefs.SetInt ("Golok Iron", 0);
			PlayerPrefs.SetInt ("Golok Silver", 0);
			PlayerPrefs.SetInt ("Golok Steel", 0);
		}
	}
}
