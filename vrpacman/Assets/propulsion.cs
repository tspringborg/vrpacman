using UnityEngine;
using System.Collections;

public class propulsion : MonoBehaviour {


	public float power;
	private Quaternion rot;
	private Rigidbody rg;
	// Use this for initialization
	void Start () {
		rot = this.gameObject.transform.rotation;
		rg = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		/*
		obj2.localRotation = new Quaternion(obj1.localRotation.x * -1.0f,
			obj1.localRotation.y,
			obj1.localRotation.z,
			obj1.localRotation.w * -1.0f);
		*/
		rg.AddForce(transform.forward * power);
	}
}
