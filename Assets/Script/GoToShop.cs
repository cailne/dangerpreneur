﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToShop : MonoBehaviour {

	public void ChangeToShop(){
		SceneManager.LoadScene ("Shop");
	}
}
