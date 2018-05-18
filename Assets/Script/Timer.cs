using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

//public PersistentVariables pv;
public Text month;
public Text year;
public float TrueTime, ttm;
private float timeCore;

	void Start () {
		timeCore = Time.time;
		//PlayerPrefs.SetFloat("Time",0f);
		if(PlayerPrefs.GetFloat("Time") <= 0){
			ttm = 0;
		}else if (PlayerPrefs.GetFloat("Time") > 0){
			ttm = PlayerPrefs.GetFloat("Time");
		}
		TrueTime += ttm;
	}
	void Update () {
		TrueTime = (Time.time - timeCore);


		string m = ((int) (TrueTime / 10) % 13 + 1).ToString();
		string y = ((int) (TrueTime / 120) + 1600).ToString();

		

		month.text = m;
		year.text = y;
	}
}




