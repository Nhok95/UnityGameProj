using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoAlerta : MonoBehaviour {

	public float speedSearch = 120f;
	public float timeSearch = 3f;

	private MaquinaDeEstados mEstados;
	private ControladorNavMesh cNavMesh;
	private ControladorVision cVision;
	private AudioSource audio;
	public AudioClip AlertZombie;
	private float timeSearching;

	// Use this for initialization
	void Awake () {
		mEstados = GetComponent<MaquinaDeEstados> ();
		cNavMesh = GetComponent<ControladorNavMesh> ();
		cVision = GetComponent<ControladorVision> ();
		audio = GetComponent<AudioSource> ();
		timeSearching = 0f;
	}

	void OnEnable()
	{
		cNavMesh.StopNav ();
		audio.clip = AlertZombie;
		audio.Play ();
		timeSearching = 0f;
	}
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (cVision.PlayerDetected (out hit)) 
		{
			cNavMesh.followObj = hit.transform;
			mEstados.ActivarEstado (mEstados.EstadoPersecusion);
			return;
		}

		transform.Rotate(0f,speedSearch * Time.deltaTime, 0f);
		timeSearching += Time.deltaTime;
		if (timeSearching >= timeSearch) 
		{
			mEstados.ActivarEstado (mEstados.EstadoPatrulla);
			return;
		}
	}
}
