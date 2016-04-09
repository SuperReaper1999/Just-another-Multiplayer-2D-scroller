using UnityEngine;

public class ButtonScript : MonoBehaviour {

    // Detects if something is in this objects trigger.
    void OnTriggerStay2D (Collider2D col) {
        GetComponent<SpriteRenderer>().color = new Color(0, 255, 0, 255);
        transform.GetChild(0).gameObject.SetActive(true);
    }
    // Detects when an object exits this objects trigger.
    void OnTriggerExit2D (Collider2D col) {
        GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 255);
        transform.GetChild(0).gameObject.SetActive(false);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
