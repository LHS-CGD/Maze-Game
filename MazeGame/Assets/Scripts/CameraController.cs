using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public GameObject myo = null;
	private ThalmicMyo thalmicMyo;
	private Transform playerTransform;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		playerTransform = player.transform;
		offset = transform.position - player.transform.position;
		thalmicMyo = myo.GetComponent<ThalmicMyo> ();
		transform.rotation = new Quaternion (0f, 0f, 0f, 0f);
	}

	void Update() {
		this.transform.rotation = new Quaternion(thalmicMyo.transform.rotation.x, thalmicMyo.transform.rotation.y,
			thalmicMyo.transform.rotation.z, thalmicMyo.transform.rotation.w);
	}

	void LateUpdate () {
		
		transform.position = player.transform.position + offset;
	}
}
