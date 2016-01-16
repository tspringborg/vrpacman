using UnityEngine;
using UnityEngine.Networking;
using System.Collections;



public class CustomNetworkManager : NetworkManager {
	

	private string hostIP = "10.40.0.170";

	public void Awake(){
		networkAddress = hostIP;
		StartClient();
	}
	public void Start(){
		
	}
}
