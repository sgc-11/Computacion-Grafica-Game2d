using UnityEngine;
using TMPro; // Importing TextMeshPro namespace for text handling

public class aaaaaaaaaaa : MonoBehaviour
{
    public GameObject winTextObject; // Reference to the player object
    private TextMeshProUGUI winText; // Reference to the win text object
    [SerializeField] private string winTextMessage; // Message to display when the object is taken
    [SerializeField] private string sceneToLoad; 
    public SceneLoader sceneLoader; // Reference to the SceneLoader script

    private void Awake() {
        winTextObject = GameObject.Find("WinText"); // Find the win text object in the scene
        winText = winTextObject.GetComponent<TextMeshProUGUI>(); // Get the TextMeshProUGUI component from the win text object
    }
    private void Start() {
        winTextObject.SetActive(false); // Deactivate the win text at the start
    }

    public void ObjectTaken() {
        winText.text = winTextMessage; // Set the win text message
        if (sceneLoader != null) {
            sceneLoader.SceneChange(sceneToLoad); // Load the specified scene if the SceneLoader reference is not null
        }
        winTextObject.SetActive(true); // Activate the win text when the object is taken
    }
}
