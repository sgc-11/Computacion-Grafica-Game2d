using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed; // Speed of the player
    private float horizontalInput; // Horizontal input value
    private float verticalInput; // Vertical input value

    private SceneLoader sceneLoader; // Reference to the SceneLoader script

    private void Start() {
        TryGetComponent<SceneLoader>(out sceneLoader); // Try to get the SceneLoader component from the player object
    }

    private void FixedUpdate() { // FixedUpdate is used for physics-related updates. It is called at a fixed interval.
        // Get input from the player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Create a movement vector based on input and speed
        Vector3 movement = new Vector3(horizontalInput, verticalInput,0) * speed* Time.deltaTime;

        // Move the player
        transform.Translate(movement);    
    }

    private void Update() {
        if  (Input.GetKeyDown(KeyCode.Space)) { // Check if the Escape key is pressed
            if (sceneLoader != null) {  
                sceneLoader.SceneChange("MainScene"); // Load the main menu scene
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape)) { // Check if the Escape key is pressed
            if (sceneLoader != null) {  
                sceneLoader.QuitGame(); // Quit the game
            }
        }
    }
}
