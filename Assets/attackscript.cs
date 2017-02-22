using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GetComponent<Animator> ().Play ("sword_attack");
		} else {
			GetComponent<Animator> ().Play ("Entry");
		}
	}
}
