using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentVariables : MonoBehaviour {

	public static PersistentVariables i {get; private set;}

    public int lethality, durability, weight, cost;
    
	void Awake(){
		if (i == null) {
            i = this;
            DontDestroyOnLoad (gameObject);
            } else {
            Destroy (gameObject);
        }
	}
}
