using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour {
	public float height;
	Renderer rend;
	public AudioClip brick1;
    AudioSource audioSource;
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		audioSource = GetComponent<AudioSource>();
		rend = GetComponent<Renderer>();
		rend.material.SetColor("_Color", Color.green);
		height = Random.Range(1.0f, height);
		transform.localPosition = new Vector3(0, height/2, 0);
		transform.localScale = new Vector3(0.4f, height, 0.4f);
		rb.constraints = RigidbodyConstraints.None;

	}
	
	// Update is called once per frame
	void Update () {
	}
	public void Green(){
        rend.material.SetColor("_Color", Color.green);

	}
	public void Red(){
		audioSource.PlayOneShot(brick1);
        rend.material.SetColor("_Color", Color.red);
        Invoke("Green", 0.05f);
	}
}
