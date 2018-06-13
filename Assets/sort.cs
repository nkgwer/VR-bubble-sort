using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sort : MonoBehaviour {
	public GameObject[] cubes;
	public int i = 0,l = 0;
	public GameObject c1, c2, temp;
	private Vector3 pos;
	private bool sorting = false;
	TowerController t1, t2;
	public float speed;
	// Use this for initialization
	void Start () {
		Invoke("getCubes", 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if(sorting){
			Invoke("do_sort", speed);
			sorting = false;
		}
	}
	void getCubes(){
		cubes = GameObject.FindGameObjectsWithTag("Cube");
		l = cubes.Length;
		sorting = true;
	}
	void do_sort(){
		if(i + 1 == l){
				i = 0;
			}
		c1 = cubes[i];
		c2 = cubes[i+1];
		t1 = c1.transform.GetChild(0).GetComponent<TowerController>();
		t2 = c2.transform.GetChild(0).GetComponent<TowerController>();
		t1.Red();
		t2.Red();
		if(c1.transform.GetChild(0).lossyScale.y > c2.transform.GetChild(0).lossyScale.y){
			pos = c1.transform.position;
			c1.transform.position = c2.transform.position;
			c2.transform.position = pos;
			temp = cubes[i];
			cubes[i] = cubes[i+1];
			cubes[i+1] = temp;

		}
		i++;
		sorting = true;
	}
}
