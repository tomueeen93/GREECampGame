using UnityEngine;
using System.Collections;

public class FallTriggerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("Enter : "+other.name);
		if (other.gameObject.tag == "GoodCharactor"||other.gameObject.tag == "BadCharactor") {
			other.gameObject.transform.rigidbody2D.fixedAngle = false;
		}
	}
}
