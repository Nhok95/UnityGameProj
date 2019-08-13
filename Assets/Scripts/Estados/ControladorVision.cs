using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorVision : MonoBehaviour {

	public Transform Vision;
	public float VisionRange = 15f;
	public Vector3 offset = new Vector3(0f,0.50f,0f);

	private ControladorNavMesh cNavMesh;

	void Awake()
	{
		cNavMesh = GetComponent<ControladorNavMesh> ();
	}

	public bool PlayerDetected(out RaycastHit hit, bool seePlayer = false)
	{
		Vector3 vDir;
		if (seePlayer) 
		{
			vDir = (cNavMesh.followObj.position + offset) - Vision.position;
		} else 
		{
			vDir = Vision.forward;
		}

		return Physics.Raycast (Vision.position, vDir, out hit, VisionRange) &&
		hit.collider.CompareTag ("Player");
	}

}
