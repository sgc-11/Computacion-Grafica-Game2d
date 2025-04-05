using UnityEngine;

public class PickeableScale : MonoBehaviour
{
    [SerializeField] private float scaleFactor; 
    [SerializeField] private float rotataDirection;
    
    [SerializeField] private bool isWinCondition; // Flag to check if the object is a win condition
    private aaaaaaaaaaa script; // Reference to the script that handles win text activation
    private void Awake() {
        script = GetComponent<aaaaaaaaaaa>(); // Get the script component from the win text object
    } 

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            // Scale the player object when it collides with the trigger
            other.transform.localScale *= scaleFactor;
            // Destroy the pickable object after scaling
            //Destroy(gameObject);
            ObjectTaken(); // Call the method to handle object taken
        }
    }

    private void Update() {
        transform.Rotate(0,0,rotataDirection * Time.deltaTime); // Rotate the object continuously
    }

    private void ObjectTaken(){
        if (isWinCondition) {
            script.ObjectTaken(); // Call the method to activate the win text if this is a win condition
        };// Activate the win text if this is a win condition
        gameObject.SetActive(false); // Deactivate the object instead of destroying it
    }
}
