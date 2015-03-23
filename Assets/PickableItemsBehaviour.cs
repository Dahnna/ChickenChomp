using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PickableItemsBehaviour : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			Destroy(this.gameObject);
			UpdateText();
		}
	}

	void UpdateText()
	{
		GameObject.Find ("/Canvas1/Text").GetComponent<ItemCountBehaviour>().DecreaseItemCount();
	}
}
