using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class ExitDoorScript : NetworkBehaviour {

    private int numberOfPlayersAtDoor = 0;

    // Called when something enters the doors trigger.
    void OnTriggerEnter2D (Collider2D col) {
        if (isServer)
        {
            numberOfPlayersAtDoor++;
            if (numberOfPlayersAtDoor == 2)
            {
                // This is basically a total hack because I don't feel like saving/loading levels.
                string[] level = SceneManager.GetActiveScene().name.Split(' ');
                GameObject.Find("NetworkManager").GetComponent<NetworkManager>().ServerChangeScene("Level " + (Convert.ToInt32(level[1]) + 1));
            }
        }
    }

    // Called when something exits the doors trigger.
    void OnTriggerExit2D (Collider2D col)
    {
        if (isServer)
        {
            numberOfPlayersAtDoor--;
        }
    }
}
