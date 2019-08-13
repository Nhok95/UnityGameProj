using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour {

	public GameObject Zombie;
	public GameObject Gameover;
	public GameObject Player;


	private Animator anim;
	private AudioSource audio;
	// Use this for initialization
	void Start () {
		anim = Player.GetComponent<Animator> ();
		audio = Player.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.CompareTag("Player"))
		{
			Zombie.GetComponent<Animator> ().SetTrigger ("attack");
			anim.SetTrigger ("Death");
			audio.Play ();


			StartCoroutine (Wait (3));

		}
	}

	IEnumerator Wait(int seconds) 
	{
		//yield return new WaitForSeconds (seconds);
		yield return new WaitForSeconds (seconds);
		Gameover.GetComponent<Animator> ().SetTrigger ("GameOver");
	}
}
