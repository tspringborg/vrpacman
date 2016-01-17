using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SceneManager.LoadScene("Environment", LoadSceneMode.Additive);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
