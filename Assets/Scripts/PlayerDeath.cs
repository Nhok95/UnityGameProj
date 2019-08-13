	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {
	public MonoBehaviour FPC;

	void Start () {
	}
	void Update () {
	}

	public void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.CompareTag("EnemyAttack"))
		{
			FPC.enabled = false;
		}
	}

	public void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.CompareTag("EnemyAttack"))
		{
			FPC.enabled = false;
		}
	}
}
