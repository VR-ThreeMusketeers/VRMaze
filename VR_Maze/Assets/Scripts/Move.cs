using UnityEngine;
using System.Collections;
using Gvr;

public class Move : MonoBehaviour {

	public CharacterController player;
	public GvrAudioSource Source;
	public AudioClip Clip;
	public bool PlayAsOneShot;

	private Quaternion orientation;
	private Rect rect = new Rect (100, 100, 200, 200);



	// Use this for initialization
	void Start () {
		player = GetComponent <CharacterController> ();
//		if (Source == null) {
//			Source = GetComponent<GvrAudioSource>();
//		}
		Application.targetFrameRate = 60;
	}
	
	// Update is called once per frame
	void Update () {
		orientation = GvrController.Orientation;
		//GUI.Label(rect, headOr.ToString());
		Vector3 controlDir = orientation * Vector3.forward;
		Vector3 moveDir = new Vector3 (controlDir.x, 0, controlDir.z);
		if (GvrController.IsTouching) 
		{
			player.Move (moveDir * Time.deltaTime * 3);
		}

		//head = Camera.main.GetComponent<StereoController>().Head;
		//offset = camera.transform.rotation.eulerAngles - player.transform.rotation.eulerAngles;
		/*Vector3 camVector = Camera.main.transform.forward;
		float rotate = Vector3.Angle(player.transform.forward, camVector);
		Vector3 rotateSet = new Vector3 (0, rotate * Mathf.PI / 180, 0);
		player.transform.Rotate(rotateSet);
		player.transform.Rotate(empty);*/

		//var lookPos = Camera.main.position - transform.position;
		//lookPos.y = 0;
		//var rotation = Quaternion.LookRotation(lookPos);
		//transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 0.1);

		if (GvrController.IsTouching) {
//			Vector2 movement = GvrController.TouchPos;
//			Vector3 move3 = new Vector3 ((float)(movement.x - .5), 0, -1 * (float)(movement.y - .5));
//			player.Move (move3 * Time.deltaTime * 6);
			//player.Move (head.Gaze.direction * Time.deltaTime * 10);

//			if (Source != null && Clip != null) {
//				Source.PlayOneShot (Clip, 1f);
//			}
//				

			//Vector3 newmove = transform.rotation * move3;
			//transform.rotation = Quaternion.LookRotation(newmove);
			//Vector3 mod = move3.x * transform.forward + move3.z * transform.right;
			//player.transform.Rotate (offset);

			//player.transform.rotation = camera.transform.rotation;
			//player.Move (newmove * Time.deltaTime * 10);
			/*Quaternion quat = transform.rotation;
			Vector2 diference = new Vector2((quat.x - move3.x), (quat.z - move3.z));
			float sign = (quat.z < move3.z)? -1.0f : 1.0f;
			float angle = Vector2.Angle(Vector2.right, diference) * sign * Mathf.PI / 180;
			Vector3 newvec = new Vector3 (Mathf.Cos (angle) * move3.x - Mathf.Sin (angle) * move3.z, 0, Mathf.Sin (angle) * move3.x + Mathf.Cos (angle) * move3.z);
			player.Move (move3 * Time.deltaTime * 10);*/
		}

//		else {
//			Source.Stop();
//			Source.clip = Clip;
//			//Source.Play();
//		}
	}

	void OnGUI()
	{
 
	}


}
