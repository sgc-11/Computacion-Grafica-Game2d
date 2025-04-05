using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void SceneChange(string sceneName) // Method to load a new scene
    {
        SceneManager.LoadScene(sceneName); // Load the specified scene
    }

    public void QuitGame() // Method to quit the game
    {
        Application.Quit(); // Quit the application
        Debug.Log("Game is exiting"); // Log a message to the console
    }
}
