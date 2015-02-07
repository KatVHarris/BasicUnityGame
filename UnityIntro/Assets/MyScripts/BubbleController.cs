using UnityEngine;
using System.Collections;

public class BubbleController : MonoBehaviour {
	

	void OnTriggerEnter(Collider collision){
		GameObject objectHit = collision.collider.gameObject;

		if (objectHit.tag == "Player") {
						//Update Player Inventory with Bubble
			objectHit.GetComponent<InventoryController>().AddBubble();
			Destroy(this.gameObject);
		}

	}
}

/*void OnCollisionEnter(Collision collision){
	GameObject objectHit = collision.collider.gameObject;
	
	if (objectHit.transform.parent != null && objectHit.transform.parent.tag == "Player") {
		objectHit.GetComponent<InventoryController>().AddBubble ();
		Destroy (this.gameObject);
	} else {
		if (objectHit.tag == "Player") {
			objectHit.GetComponent<InventoryController>().AddBubble ();
			Destroy (this.gameObject);
		}
	}
}*/