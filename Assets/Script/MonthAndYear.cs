using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MonthAndYear : MonoBehaviour {

	public Text ShowYear;

	public Text ShowMonth;

	public float MonthRealTime;

	public int MonthInNumber = 1;

	public Image LinearTimer;

	public int Year = 1672;


	// Use this for initialization
	void Start () {
		MonthRealTime = 5;
		ShowYear.text = Year.ToString();
		TimeCheck ();
	}
	
	// Update is called once per frame
	void Update () {
		if (MonthRealTime > 0) {
			MonthRealTime -= Time.deltaTime;
			LinearTimer.fillAmount = MonthRealTime / 5;
		} else {
			MonthInNumber += 1;
			Start ();
		}

	}

	void TimeCheck(){
		if (MonthInNumber > 12) {
			MonthInNumber = 1;
			ShowMonth.text = "January";
			Year += 1;
		} else {
			if (MonthInNumber == 1) {
				ShowMonth.text = "January";
			} if (MonthInNumber == 2) {
				ShowMonth.text = "February";
			} if (MonthInNumber == 3) {
				ShowMonth.text = "March";
			}if (MonthInNumber == 4) {
				ShowMonth.text = "April";
			}if (MonthInNumber == 5) {
				ShowMonth.text = "May";
			}if (MonthInNumber == 6) {
				ShowMonth.text = "June";
			}if (MonthInNumber == 7) {
				ShowMonth.text = "July";
			}if (MonthInNumber == 8) {
				ShowMonth.text = "August";
			}if (MonthInNumber == 9) {
				ShowMonth.text = "September";
			}if (MonthInNumber == 10) {
				ShowMonth.text = "October";
			}if (MonthInNumber == 11) {
				ShowMonth.text = "November";
			} if(MonthInNumber == 12) {
				ShowMonth.text = "December";
			}
		}
	}
}
