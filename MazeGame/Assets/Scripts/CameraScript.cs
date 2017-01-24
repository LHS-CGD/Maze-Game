using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public GameObject myo;
	private ThalmicMyo thalmicMyo;
	public Transform parenttransform;
	// Use this for initialization
	void Start () {
		thalmicMyo = myo.GetComponent<ThalmicMyo>();
		parenttransform.rotation = new Quaternion(0f, 0f, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		parenttransform.rotation = new Quaternion(thalmicMyo.transform.rotation.x, thalmicMyo.transform.rotation.y, 
			thalmicMyo.transform.rotation.z, thalmicMyo.transform.rotation.w);
	}
}
