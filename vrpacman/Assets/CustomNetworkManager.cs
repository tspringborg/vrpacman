using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Utility;



public class CustomNetworkManager : NetworkManager {

	public Transform playerViewport;
	public Transform playerViewportRotate;

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
		GameObject player = (GameObject)Instantiate(playerPrefab, new Vector3(-3.85f, 1.12f, 26.47f), Quaternion.identity);
		FollowTarget followScript = playerViewport.gameObject.AddComponent<FollowTarget>();
		followScript.offset = Vector3.zero;
		followScript.target = player.transform;

		SameRotation sameRotation = player.AddComponent<SameRotation>();
		sameRotation.target = playerViewportRotate;

	}
}
