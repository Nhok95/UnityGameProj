using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour {

	public GameObject button1;
	public GameObject button2;


	private Canvas can;

	// Use this for initialization
	void Start () {
		can = gameObject.GetComponent<Canvas> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("escape")) {
			Time.timeScale = 0f;
			can.enabled = true;
			button1.SetActive (true);
			button2.SetActive (true);
		}
	}

	public void disablePause()
	{
		Time.timeScale = 1f;
		can.enabled = false;
		button1.SetActive (false);
		button2.SetActive (false);
	}

	public void ExitGame()
	{
		Application.Quit ();
	}
}
