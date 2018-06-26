using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontKill2 : MonoBehaviour {

	public GameObject DontKill;
	public static bool Created = false;
	// Use this for initialization
	void Awake(){
		if(!Created){
			DontDestroyOnLoad (DontKill);
			Created = true;
			Debug.Log (DontKill + " Immortalized");
		}
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
