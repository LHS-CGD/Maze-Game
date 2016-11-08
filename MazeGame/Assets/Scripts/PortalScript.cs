using UnityEngine;
using System.Collections;

public class PortalScript : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	public GameObject portal2;
	private Vector3 newSpot;
	// Use this for initialization
	void Start (){
		newSpot = portal2.transform.position;

	}

	void OnTriggerEnter(Collider portal)
	{
		player.transform.position = newSpot;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
