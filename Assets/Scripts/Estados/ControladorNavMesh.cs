using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControladorNavMesh : MonoBehaviour {

	[HideInInspector]
	public Transform followObj;
	public NavMeshAgent navMeshAgent;

	void Awake () 
	{
		navMeshAgent = GetComponent<NavMeshAgent> ();
	}
	

	void Update () 
	{
		float v = navMeshAgent.velocity.magnitude;

		GetComponent<Animator> ().SetFloat ("Movement", v);

	}

	public void ActualizarPDNavMeshAgent(Vector3 PD)
	{
		navMeshAgent.destination = PD;
		navMeshAgent.Resume ();
	}

	public void ActualizarPDNavMeshAgent()
	{
		ActualizarPDNavMeshAgent (followObj.position);
	}

	public void StopNav()
	{
		navMeshAgent.Stop ();
	}

	public bool Meta()
	{
		return navMeshAgent.remainingDistance <=
			navMeshAgent.stoppingDistance &&
			!navMeshAgent.pathPending;
	}
		
}
