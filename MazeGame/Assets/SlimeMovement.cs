using UnityEngine;
using System.Collections;

public class SlimeMovement : MonoBehaviour {

	private Rigidbody rb;
	private float velocity = 5f;
	private float nextActionTime = 0.0f;
	public float period = 1.5f;
	//false = move left; right = move right
	private bool direction = false;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		if (Time.time > nextActionTime) {
			nextActionTime += period;
			float comp;
			if (direction) {
				comp = -3;
				direction = false;
			} else {
				comp = 3;
				direction = true;
			}

			rb.AddForce(new Vector3(comp, Mathf.Abs(comp), comp*Random.Range(0.0f,2f)), ForceMode.Impulse);
			}
		}
	}

