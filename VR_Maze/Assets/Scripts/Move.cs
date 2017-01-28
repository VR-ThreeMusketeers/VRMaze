using UnityEngine;
using System.Collections;
using Gvr;

public class Move : MonoBehaviour {

	public CharacterController player;
	public Camera camera = Camera.main;
	//private Vector3 offset;

	// Use this for initialization
	void Start () {
		player = GetComponent <CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		//offset = camera.transform.rotation.eulerAngles - player.transform.rotation.eulerAngles;

		if (GvrController.IsTouching) {
			Vector2 movement = GvrController.TouchPos;
			Vector3 move3 = new Vector3 ((float)(movement.x - .5), 0, -1 * (float)(movement.y - .5));
			Vector3 newmove = camera.transform.TransformDirection (move3);
			transform.rotation = Quaternion.LookRotation(newmove);
			//Vector3 mod = move3.x * transform.forward + move3.z * transform.right;
			//player.transform.Rotate (offset);

			//player.transform.rotation = camera.transform.rotation;
			player.Move (move3 * Time.deltaTime * 10);
			/*Quaternion quat = transform.rotation;
			Vector2 diference = new Vector2((quat.x - move3.x), (quat.z - move3.z));
			float sign = (quat.z < move3.z)? -1.0f : 1.0f;
			float angle = Vector2.Angle(Vector2.right, diference) * sign * Mathf.PI / 180;
			Vector3 newvec = new Vector3 (Mathf.Cos (angle) * move3.x - Mathf.Sin (angle) * move3.z, 0, Mathf.Sin (angle) * move3.x + Mathf.Cos (angle) * move3.z);
			player.Move (move3 * Time.deltaTime * 10);*/
		}
	}



}
