using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentVariables : MonoBehaviour {

    //private float timeC;
	public static PersistentVariables i {get; private set;}

    public int lethality, durability, weight, cost, addedItem;
    //int[] IdInv = new int[15] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

    public MsItem siwar11, siwar12, siwar13, siwar14, siwar15;
    public MsItem jenawi11, jenawi12, jenawi13, jenawi14, jenawi15;
    public MsItem trisula11, trisula12, trisula13, trisula14, trisula15;
    public MsItem golok11, golok12, golok13, golok14, golok15;
    
	void Awake(){
		if (i == null) {
            i = this;
            DontDestroyOnLoad (gameObject);
            } else {
            Destroy (gameObject);
        }
	}

    /*void Start(){
        if(timeC <= 0) timeC = Time.time;
    }

    void Update(){
        float tm = Time.time - timeC;

        month = (int) (tm / 10) % 13 + 1;
        year = (int) tm / 120;
    }*/
}
