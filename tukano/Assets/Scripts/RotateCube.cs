using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {


	public float vel_x;
	public float vel_y;
	public float vel_z;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (vel_x, vel_y, vel_z) * Time.deltaTime); 

	}


}
