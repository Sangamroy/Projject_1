using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControler : MonoBehaviour {

	public static MovementControler instance;
	public Vector3 forward=new Vector3();
	public Transform vrhead;
	public float speed=3f;
	public float curSpeed;
	CharacterController Controller;
	// Use this for initialization
	void Start () {
		instance = this;
		Controller = transform.GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
//		moveforward = transform.forward;
//		transform.position = moveforward * Input.GetAxis ("Vertical");
		forward = vrhead.TransformDirection(Vector3.forward);
		curSpeed = speed * Input.GetAxis ("Vertical");
		Controller.SimpleMove (forward*curSpeed);
		
	}


}
