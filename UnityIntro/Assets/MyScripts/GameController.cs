using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	float restartTimer;                     // Timer to count up to restarting the level
	public float restartDelay = 35f;         // Time to wait before restarting the level

	public InventoryController inventory;
	public int maxBubble = 3; 
	public Animator anim;

	// Use this for initialization
	void Awake () {
		//GameObject playerobject = GameObject.Find ("Player");
		//inventory = playerobject.GetComponent<InventoryController>();
	}
	
	// Update is called once per frame
	void Update () {
		//Check to see if Inventory has max bubbles
		if (inventory.bubbleCount == maxBubble) {
			anim.SetTrigger("GameOver");
			//end game
			restartTimer += Time.deltaTime;
			
			// .. if it reaches the restart delay...
			if(restartTimer >= restartDelay)
			{
				// .. then reload the currently loaded level.
				Application.LoadLevel(Application.loadedLevel);
			}
		}

	}


}
