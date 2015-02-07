using UnityEngine;
using System.Collections;

public class InventoryController : MonoBehaviour {

	public int bubbleCount = 0; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddBubble(){
		bubbleCount = bubbleCount + 1; // bubbleCount++; 
		ScoreController.score++;
	}
}
