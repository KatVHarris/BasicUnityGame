using UnityEngine;
using System.Collections;

public class TestMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public float speed = 3.0f; 
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-Input.GetAxis ("Horizontal") * speed * Time.deltaTime, 0, 0);
	}
}
