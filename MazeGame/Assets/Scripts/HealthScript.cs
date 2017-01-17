using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class HealthScript : MonoBehaviour {
	public int health = 100;
	private Vector3 startPosition;
	public GameObject healthText;
	 Text text;

	// Use this for initialization
	void Start () {
		startPosition = this.transform.position;
		text = healthText.GetComponent<Text>();
		text.text = health.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collider){
		Debug.Log(collider.gameObject.name);
		if (collider.gameObject.name.Equals ("slime")) {
			health -= 10;
			text.text = health.ToString ();
		}
		if (health <= 0) {
			this.transform.position = startPosition;
			health = 100;
			text.text = health.ToString ();
		}
			
	}
}
