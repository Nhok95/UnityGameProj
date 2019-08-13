using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour {

	public GameObject lluvia;

	private AudioSource las;
	// Use this for initialization
	void Start () {
		las = lluvia.GetComponent<AudioSource> ();
		Time.timeScale = 0f;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void disable(bool value)
	{
		Time.timeScale = 1f;
		las.mute = false;
		gameObject.SetActive (value);
	}

	public void ExitGame()
	{
		Application.Quit ();
	}
}
