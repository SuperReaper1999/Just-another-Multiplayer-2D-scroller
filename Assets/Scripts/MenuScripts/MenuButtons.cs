using UnityEngine;
using UnityEngine.Networking;

public class MenuButtons : MonoBehaviour {

    // Disables all currently active canvases.
    public void ResumeGame () {
        GameObject settingsMenu = GameObject.Find("SettingsMenu");
        settingsMenu.GetComponent<Canvas>().enabled = false;

        GameObject pauseMenu = GameObject.Find("PauseMenu");
        pauseMenu.GetComponent<Canvas>().enabled = false;
    }

    // Closes the game.
    public void ExitGame () {
        Application.Quit();
    }

    // Opens the settings menu.
    public void SettingsButton () {
        GameObject settingsMenu = GameObject.Find("SettingsMenu");
        settingsMenu.GetComponent<Canvas>().enabled = true;
    }

    public void LanButton() {
        NetworkManager.singleton.StartClient();
        NetworkManager.singleton.StartHost();
    }
}
