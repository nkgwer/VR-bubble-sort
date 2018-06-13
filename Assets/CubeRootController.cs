using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRootController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public float ChildHeight(){
		return this.gameObject.transform.GetChild(0).lossyScale.y;
	}
}
