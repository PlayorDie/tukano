﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	private  int ponto;
	private Rigidbody rb;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();

	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (movement * speed);
	}



	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("cbuo")){
			ponto++;
			//other.gameObject.SetActive(false);
			Destroy(other.gameObject);
			placar.ToString = TextEditor
		}
	}
}
