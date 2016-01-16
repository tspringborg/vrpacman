using UnityEngine;
using UnityEngine.Networking;
using System.Collections;



public class CustomNetworkManager : NetworkManager {
	

	//private string hostIP = "10.40.0.170"; //ts
	//private string hostIP = "10.40.0.176"; //ns
	private string hostIP = "10.40.0.192"; //julie

	public void Awake(){
		networkAddress = hostIP;
		StartClient();
	}
	public void Start(){
		
	}
}
