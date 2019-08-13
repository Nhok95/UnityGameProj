using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour {
	private Rigidbody rb;
	private Animator anim;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetFloat ("SpeedX", Input.GetAxis("Horizontal"));
		anim.SetFloat ("SpeedZ", Input.GetAxis("Vertical"));
	}
}
