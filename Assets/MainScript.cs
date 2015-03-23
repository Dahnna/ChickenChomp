using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {

	Camera cam1;
	Camera cam2;
	Camera cam3;
	
	Canvas canvas1;
	Canvas canvas2;
	Canvas canvas3;

	// Use this for initialization
	void Start () {
		cam1 = GameObject.Find ("Main Camera").GetComponent<Camera>();
		cam2 = GameObject.Find ("Camera2").GetComponent<Camera>();
		cam3 = GameObject.Find ("Camera3").GetComponent<Camera>();
		canvas1 = GameObject.Find ("Canvas1").GetComponent<Canvas>();
		canvas2 = GameObject.Find ("Canvas2").GetComponent<Canvas>();
		canvas3 = GameObject.Find ("Canvas3").GetComponent<Canvas>();
		cam1.enabled = true;
		cam2.enabled = false;
		cam3.enabled = false;
		canvas1.enabled = true;
		canvas2.enabled = false;
		canvas3.enabled = false;
		Screen.showCursor = false; 
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.V) && cam1.enabled)
		{
			// camera 2
			cam1.enabled = false;
			cam2.enabled = true;
			cam3.enabled = false;
			canvas1.enabled = false;
			canvas2.enabled = true;
			canvas3.enabled = false;
		}
		else if (Input.GetKeyDown(KeyCode.V) && cam2.enabled)
		{
			// camera 3
			cam1.enabled = false;
			cam2.enabled = false;
			cam3.enabled = true;
			canvas1.enabled = false;
			canvas2.enabled = false;
			canvas3.enabled = true;

		}
		else if (Input.GetKeyDown(KeyCode.V) && cam3.enabled)
		{
			// camera 1
			cam1.enabled = true;
			cam2.enabled = false;
			cam3.enabled = false;
			canvas1.enabled = true;
			canvas2.enabled = false;
			canvas3.enabled = false;
		}
	}
}
