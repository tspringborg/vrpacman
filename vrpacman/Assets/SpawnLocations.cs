using UnityEngine;
using System.Collections;

public static class SpawnLocations {
	public static Vector3 ForNewPlayer(int numPlayers){
		Debug.Log("SpawnLocation for player: "+numPlayers);
		Vector3 pos = Vector3.zero;
		switch(numPlayers){
		case 0:
		case 1:
			pos = new Vector3(-3.85f, 1.12f, 26.47f);
			break;
		case 2:
			pos = new Vector3(17.03f, 1.12f, 9.6f);
			break;
		case 3:
			pos = new Vector3(-19.9f, 1.12f, -13.9f);
			break;
		case 4:
			pos = new Vector3(-19.74f, 1.12f, 14.5f);
			break;
		default:
			break;
		}
		return pos;
	}
}
