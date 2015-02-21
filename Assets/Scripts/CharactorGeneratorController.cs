using UnityEngine;
using System.Collections;

public class CharactorGeneratorController : MonoBehaviour {
	public float wait_second = 1;
	public float random_direction = 2;
	public GameObject bad_charactor_object;
	public GameObject good_charactor_object;
	public double good_probability = 30;
	public float framecount = 0;

	// Use this for initialization
/*
	void Start () {
		StartCoroutine("Generate");
		Debug.Log ("test");
	}
*/

	void Start()
	{
		StartCoroutine(Generate());
	}
	
	IEnumerator Generate()
	{
		while(true)
		{
			if(Random.Range(0,100)<good_probability)Instantiate (good_charactor_object,transform.position,transform.rotation);
			else Instantiate (bad_charactor_object,transform.position,transform.rotation);

			yield return new WaitForSeconds(wait_second+Random.Range(0,random_direction));
		}
	}
}
