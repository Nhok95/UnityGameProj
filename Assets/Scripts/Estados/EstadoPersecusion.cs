using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoPersecusion : MonoBehaviour {

	private MaquinaDeEstados mEstados;
	private ControladorNavMesh cNavMesh;
	private ControladorVision cVision;
	private AudioSource audio;
	public AudioClip AngryZombie;

	// Use this for initialization
	void Awake () 
	{
		mEstados = GetComponent<MaquinaDeEstados> ();
		cNavMesh = GetComponent<ControladorNavMesh> ();
		cVision = GetComponent<ControladorVision> ();
		audio = GetComponent<AudioSource> ();
	}

	void OnEnable() 
	{
		audio.clip = AngryZombie;
		audio.Play ();
	}
	
	// Update is called once per frame
	void Update () 
	{

		RaycastHit hit;
		if (!cVision.PlayerDetected (out hit, true)) 
		{
			mEstados.ActivarEstado (mEstados.EstadoAlerta);
			return;
		}
		cNavMesh.ActualizarPDNavMeshAgent ();
	}
		
}
