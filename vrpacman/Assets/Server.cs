using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Server : NetworkManager {


	public void Awake(){
		StartHost();
	}
	public void Start(){
		SceneManager.LoadScene("Environment", LoadSceneMode.Additive);
	}
	// called when a new player is added for a client
	public virtual void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
	{
		/*
		var player = (GameObject)GameObject.Instantiate(playerPrefab, playerSpawnPos, Quaternion.identity);
		NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
		*/
		base.OnServerAddPlayer(conn, playerControllerId);
	}
}
