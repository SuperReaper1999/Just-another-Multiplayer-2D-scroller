using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuInputHandler : MonoBehaviour {

    private Canvas pauseMenu;
    private Canvas settingsMenu;

    // Called on initialization.
    void Start () {
        settingsMenu = GameObject.Find("SettingsMenu").GetComponent<Canvas>();
        settingsMenu.enabled = false;

        pauseMenu = GameObject.Find("PauseMenu").GetComponent<Canvas>();
        pauseMenu.enabled = false;
    }

	// Update is called once per frame
	void Update () {

        if (Input.GetButtonUp("Pause"))
        {
            PauseHandler();
        }
    }

    void PauseHandler () {
        if (!pauseMenu.enabled && !settingsMenu.enabled && SceneManager.GetActiveScene().name != "MainMenu")
        {
            pauseMenu.enabled = true;
        }
        else if (pauseMenu.enabled)
        {
            pauseMenu.enabled = false;
        }
        else if (settingsMenu.enabled)
        {
            settingsMenu.enabled = false;
        }
    }
}
