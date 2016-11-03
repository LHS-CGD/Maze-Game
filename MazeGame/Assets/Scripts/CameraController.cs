using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Transform playerTransform;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		playerTransform = player.transform;
		offset = transform.position - player.transform.position;


	}


	void LateUpdate () {
		
		transform.position = player.transform.position + offset;
	}
}
