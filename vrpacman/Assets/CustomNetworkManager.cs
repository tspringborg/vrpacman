using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.SceneManagement;



public class CustomNetworkManager : NetworkManager {
	

	//private string hostIP = "10.40.0.170"; //ts
	private string hostIP = "10.40.0.176"; //ns
	//private string hostIP = "10.40.0.192"; //julie
	//private string hostIP = "10.40.1.51"; //samuel

	public void Awake(){
		networkAddress = hostIP;
		StartClient();
	}
	public void Start(){
		
	}
	public override void OnClientConnect (NetworkConnection conn)
	{
		base.OnClientConnect (conn);
		SceneManager.LoadScene("Environment", LoadSceneMode.Additive);

	}
}
