using UnityEngine;
using System.Collections;

public class ObjectDestroyerController : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D other){
		Destroy (other.gameObject);
	}
}
