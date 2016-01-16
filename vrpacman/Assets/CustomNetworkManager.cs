using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class CustomNetworkManager : NetworkManager {

	[Header("Leave empty to use localhost")]
	public string hostIP;

	public void Awake(){
		Debug.Log("hostIP:"+hostIP);
		if(hostIP !=""){
			networkAddress = hostIP;
			StartClient();
		}else{
			StartHost();
		}
	}
	public void Start(){
		
	}
}
