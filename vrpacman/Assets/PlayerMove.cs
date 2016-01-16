﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerMove : NetworkBehaviour
{
	void Update()
	{
		if (!isLocalPlayer)
			return;

		var x = Input.GetAxis("Horizontal")*0.1f;
		var z = Input.GetAxis("Vertical")*0.1f;

		transform.Translate(x, 0, z);
	}
	public override void OnStartLocalPlayer()
	{
		Debug.Log("Hello from player move");
		GetComponent<MeshRenderer>().material.color = Color.red;
	}
}
