using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
	public int n;
	public Transform cube;
	public int radius;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < n; i++)
        {
            Instantiate(cube, new Vector3(radius*Mathf.Sin(1.0f * Mathf.PI * i/n), 0.0f, radius*Mathf.Cos(1.0f * Mathf.PI * i/n)), Quaternion.identity);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
