using UnityEngine;
using UnityEngine.Networking;

public class PlayerNetworkSetup : NetworkBehaviour {

    [SerializeField]
    private Behaviour[] objectsToDisable;

	// Use this for initialization.
	void Start () {
        if (isLocalPlayer)
        {
            gameObject.layer = 8;
        }
        if (!isLocalPlayer)
        {
            for (int i = 0; i < objectsToDisable.Length; i++)
            {
                objectsToDisable[i].enabled = false;
            }
        }
	}
}
