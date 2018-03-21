using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

public Text month;
public Text year;
private float timeCore;

	void Start () {
		timeCore = Time.time;
	}
	void Update () {
		float t = Time.time - timeCore;

		string m = ((int) (t / 10) % 13 + 1).ToString();
		string y = ((int) t / 120 + 1698).ToString();

		month.text = m;
		year.text = y;
	}
}




