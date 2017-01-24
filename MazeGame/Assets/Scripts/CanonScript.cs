using UnityEngine;
using System.Collections;

public class CanonScript : MonoBehaviour {

	public ThalmicMyo myo;
	private GameObject gg;
	private RaycastHit hit;
	private Rigidbody rb;
	public Transform slime;
	// private float nextActionTime = 0.0f;
	// public float period = 1f;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		 // if (Time.time > nextActionTime ) {
   //     		nextActionTime += period;
       		if (Input.GetKeyDown (KeyCode.Space)){ 
       			rb.useGravity = false;
       			Vector3 temp = new Vector3(0, 5000, 0);
				rb.AddForce(temp, ForceMode.Impulse);
				rb.useGravity = true;
       		}
			if(myo.pose == Thalmic.Myo.Pose.Fist) {
				if(Physics.Raycast(transform.position,transform.forward,out hit,10)) {
					string s = hit.collider.gameObject.name;
					// Debug.Log(s);
					// if(s.Equals("slime")) {
					// 	gg=hit.collider.gameObject;
					// 	Debug.Log(gg.name);
					// 	gg.transform.position = transform.position;
					float speed = 10;
					if(!s.Equals("Plane")) {
						slime.position = Vector3.MoveTowards(slime.position, transform.position+new Vector3(1,1,1), speed*Time.deltaTime);
					} else  {
						Debug.Log("adding force");
						Vector3 temp = new Vector3(0, 5000, 0);
						rb.AddForce(temp, ForceMode.Impulse);
					}
				}
		//}
	
	}
}

	void OnCollisionEnter(Collision collision) {
		// Transform slime = gg.transform;
		// //Debug.Log (collision.gameobject.name);
		// GameObject temp = collision.gameObject;
		
		// if(temp.name.Equals("slime")) {
		// 	float count = 1;
		// 	while(myo.pose == Thalmic.Myo.Pose.Fist) {
		// 		if(count>10) {
		// 			break;
		// 		}
		// 		Debug.Log("RAYMOND");
		// 		Vector3 newpos = newPosition(findDistance(slime));
				
		// 		Debug.Log(newpos);
		// 		slime.position = newpos;
		// 		count++;
		// 	}
		// }
	}

	float findDistance(Transform t) {
		float dist = Vector3.Distance(t.position, this.transform.position);
		dist=30;
		
		return dist;

	}


	Vector3 newPosition(float dist) {
		Vector3 eulerAngles = this.transform.rotation.eulerAngles;
		float rotationx = eulerAngles.x;
		float rotationy = eulerAngles.y;
		float rotationz = eulerAngles.z;

		float newx = Mathf.Tan(rotationx)*dist;
		float newy = Mathf.Tan(rotationy)*dist;
		float newz = Mathf.Tan(rotationz)*dist;

		if(newy<0) {
			newy=0;
		} 

		Vector3 temp = new Vector3(newx,newy,newz);
		return temp;

	}


}
