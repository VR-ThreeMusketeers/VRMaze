using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Rigidbody rb;
	public float mult;

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();

	}

	// Update is called once per frame
	void FixedUpdate () {

		float Horizontal = Input.GetAxis ("Horizontal");
		float Vertical = Input.GetAxis ("Vertical");
		Vector3 force = new Vector3 (Horizontal, 0, Vertical);
		rb.AddForce (force * mult);

		/*
		if (GvrController.IsTouching) {
			Vector2 touchPos = GvrController.TouchPos;
			float Horizontal = touchPos[0];
			float Vertical = touchPos [1];
			// Do something.
		}
		Vector3 force = new Vector3 (Horizontal, 0, Vertical);
		*/
	}
}
