using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingAddItem : MonoBehaviour {

    public MsItem golokrandom;

	// Use this for initialization
	void Start () {
        Inventory.instance.Add(golokrandom);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
