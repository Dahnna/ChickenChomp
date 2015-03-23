using UnityEngine;
using System.Collections;

public class collisionSound : MonoBehaviour {

	private AudioSource audioSrc;

	// Use this for initialization
	void Start () {
		audioSrc = GetComponent<AudioSource> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		float force = collision.relativeVelocity.magnitude;
		audioSrc.volume = force / 50;
		audioSrc.Play ();
	}
}
