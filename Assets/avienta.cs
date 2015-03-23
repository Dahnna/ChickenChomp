using UnityEngine;
using System.Collections;

public class avienta : MonoBehaviour {

	public Transform projectile;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetButtonDown("Fire2"))
		{
			Transform proj = GameObject.Instantiate(projectile,transform.position + (transform.forward * 5.0f)+(transform.up *2.0f),Quaternion.identity) as Transform;
			proj.rigidbody.AddForce(transform.forward * 20f, ForceMode.Impulse);
		}
	}
}

