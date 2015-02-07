using UnityEngine;
using System.Collections;

public class Collides : MonoBehaviour {
	
	void OnTriggerEnter(Collider collision){
		Debug.Log ("got here");
	}
}
