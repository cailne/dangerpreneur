using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxTEMP : MonoBehaviour {

	MasterSceneChange gochange;
	
	void Start(){
		gochange = GameObject.Find("SceneChangepls").GetComponent<MasterSceneChange>();
	}

	void OnMouseDown(){
		gochange.ToCrafting2Complete();
	}
}
