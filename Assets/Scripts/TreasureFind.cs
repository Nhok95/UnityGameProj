using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureFind : MonoBehaviour {

	public GameObject Treasure;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.CompareTag("Finish"))
		{
			StartCoroutine (Wait (1));

		}
	}

	IEnumerator Wait(int seconds) 
	{
		//yield return new WaitForSeconds (seconds);
		yield return new WaitForSeconds (seconds);
		Treasure.GetComponent<Animator> ().SetTrigger ("End");
	}
}
