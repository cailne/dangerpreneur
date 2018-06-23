using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummaryCloseOpen : MonoBehaviour {
	public GameObject Summary;
	// Use this for initialization
	void Start () {
		Summary.SetActive (false);
	}

	public void OpenSummary(){
		Summary.SetActive(true);
	}

	public void CloseSummary(){
		Summary.SetActive (false);
	}
}
