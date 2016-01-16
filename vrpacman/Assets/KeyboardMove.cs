using UnityEngine;
using System.Collections;

public class KeyboardMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var x = Input.GetAxis("Horizontal")*0.15f;
		var z = Input.GetAxis("Vertical")*0.15f;

		transform.Translate(x, 0, z);
	}
}
