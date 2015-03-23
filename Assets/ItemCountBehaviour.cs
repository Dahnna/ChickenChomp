using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemCountBehaviour : MonoBehaviour {
	
	public int numberOfItemsToFind;
	
	private int itemsFound;

	// Use this for initialization
	void Start () {
		itemsFound = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DecreaseItemCount()
	{
		itemsFound++;
		this.GetComponent<Text> ().text = "Items: " + (numberOfItemsToFind - itemsFound);
	}
}
