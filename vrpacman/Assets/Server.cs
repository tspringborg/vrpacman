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
		autoCreatePlayer = true;
	}
}
