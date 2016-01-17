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
<<<<<<< HEAD
	}
	// called when a new player is added for a client
	public virtual void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
	{
		/*
		var player = (GameObject)GameObject.Instantiate(playerPrefab, Vector3 (-5,1,-23 ), Quaternion.identity);
		NetworkServer.AddPlayerForConnection(conn, player, playerControllerId); */

		base.OnServerAddPlayer(conn, playerControllerId);
=======
		autoCreatePlayer = true;
>>>>>>> a4fa4ad4f29e81caef2b77e446536af2aa777332
	}
}
