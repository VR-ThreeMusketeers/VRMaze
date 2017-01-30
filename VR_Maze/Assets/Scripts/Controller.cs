using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public GameObject ground;
	private bool walking = false;


	// Use this for initialization
	void Start () {
		ground = GetComponent <GameObject> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (walking) {
			transform.position = transform.position + Camera.main.transform.forward * 0.5f * Time.deltaTime;
		}
	}
}
