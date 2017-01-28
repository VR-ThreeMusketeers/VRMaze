using UnityEngine;
using System.Collections;
using Gvr;

public class Move : MonoBehaviour {

	public CharacterController player;
	public int speed;

	// Use this for initialization
	void Start () {
		player = GetComponent <CharacterController> ();

	}
	
	// Update is called once per frame
	void Update () {
		if(GvrController.IsTouching){
			Vector2 movement = GvrController.TouchPos;
			Vector3 move3 = new Vector3 ((float)(movement.x - .5), 0, -1 * (float)(movement.y - .5));
			Quaternion quat = transform.rotation;
			Vector2 diference = new Vector2((quat.x - move3.x), (quat.z - move3.z));
			float sign = (quat.z < move3.z)? -1.0f : 1.0f;
			float angle = Vector2.Angle(Vector2.right, diference) * sign * Mathf.PI / 180;
			Vector3 newvec = new Vector3 (Mathf.Cos (angle) * move3.x - Mathf.Sin (angle) * move3.z, 0, Mathf.Sin (angle) * move3.x + Mathf.Cos (angle) * move3.z);
			player.Move (move3 * Time.deltaTime * 10);
		}
			
	}
}
