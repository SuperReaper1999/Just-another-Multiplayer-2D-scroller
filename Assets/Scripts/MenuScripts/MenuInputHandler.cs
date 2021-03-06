using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInputHandler : MonoBehaviour {

    private Canvas pauseMenu;
    private Canvas settingsMenu;

    // Use this for initialization.
    void Start () {
        settingsMenu = GameObject.Find("SettingsMenu").GetComponent<Canvas>();
        settingsMenu.enabled = false;

        pauseMenu = GameObject.Find("PauseMenu").GetComponent<Canvas>();
        pauseMenu.enabled = false;
    }

	// Update is called once per frame.
	void Update () {

        if (Input.GetButtonUp("Pause"))
        {
            PauseHandler();
            Debug.Log("Pause Button Pressed");
        }
    }

    // Handles changing the currently active pause menus.
    void PauseHandler () {
        if (!pauseMenu.enabled && !settingsMenu.enabled && SceneManager.GetActiveScene().name != "MainMenu")
        {
            pauseMenu.enabled = true;
            Debug.Log("PauseMenu enabled");
        }
        else if (settingsMenu.enabled)
        {
            settingsMenu.enabled = false;
            Debug.Log("SettingsMenu disabled");
        }
        else if (pauseMenu.enabled)
        {
            pauseMenu.enabled = false;
            Debug.Log("PauseMenu disabled");
        }
    }
}
