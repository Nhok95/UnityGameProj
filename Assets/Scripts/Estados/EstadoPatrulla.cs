using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoPatrulla : MonoBehaviour {

	public Transform[] WayPoints;

	private MaquinaDeEstados mEstados;
	private ControladorNavMesh cNavMesh;
	private ControladorVision cVision;
	private int nextWP;

	// Use this for initialization
	void Awake () 
	{
		mEstados = GetComponent<MaquinaDeEstados> ();
		cNavMesh = GetComponent<ControladorNavMesh> ();
		cVision = GetComponent<ControladorVision> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		RaycastHit hit;
		if (cVision.PlayerDetected (out hit)) 
		{
			cNavMesh.followObj = hit.transform;
			mEstados.ActivarEstado (mEstados.EstadoPersecusion);
			return;
		}

		if (cNavMesh.Meta ()) 
		{
			nextWP = (nextWP + 1) % WayPoints.Length;
			ActualizarWPD ();

		}
	}

	void OnEnable()
	{
		ActualizarWPD ();
	}

	void ActualizarWPD()
	{
		cNavMesh.ActualizarPDNavMeshAgent (WayPoints [nextWP].position);
	}

	public void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.CompareTag("Player") && enabled)
		{
			mEstados.ActivarEstado (mEstados.EstadoAlerta);
		}
	}
}
