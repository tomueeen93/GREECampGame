using UnityEngine;
using System.Collections;

public class CharactorController : MonoBehaviour {
	public float walk_power = 3.5f;
	public float jump_power = 5;
	public float jump_random_direction = 15;
	public bool walking = false;
	public bool flying = false;
	public bool falling = false;


	// Use this for initialization
	void Start () {
		walking = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (walking) {
			transform.rigidbody2D.AddForceAtPosition (Vector2.right*walk_power,rigidbody2D.position,ForceMode2D.Force);
		}

	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name == "FallTrigger") {
			transform.rigidbody2D.fixedAngle = false;
			float p = Random.Range (jump_power,jump_power+jump_random_direction);
			transform.rigidbody2D.AddForceAtPosition (Vector2.up*p,rigidbody2D.position,ForceMode2D.Impulse);
			walking = false;
		}
	}
	public void SuperJump(){
		Vector2 dir = new Vector2(0.2f,0.8f);
		transform.rigidbody2D.AddForceAtPosition (dir*jump_power*50,rigidbody2D.position,ForceMode2D.Impulse);
	}
}
