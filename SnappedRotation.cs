using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnappedRotation : MonoBehaviour {

	public static SnappedRotation instance;
	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Horizontal")) {
			transform.Rotate (0, 20f * Input.GetAxisRaw ("Horizontal"), 0);		}


			}
}
