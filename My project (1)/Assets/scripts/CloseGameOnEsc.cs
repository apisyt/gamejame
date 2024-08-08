using UnityEngine;

public class ToggleExitButtonOnEsc : MonoBehaviour
{
    // Variable to track if the button is visible
    private bool showButton = false;

    void Update()
    {
        // Check if the Esc key was pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Toggle the button visibility
            showButton = !showButton;
        }
    }

    void OnGUI()
    {
        // If the button should be shown
        if (showButton)
        {
            // Create a button that, when clicked, closes the game
            if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), "Exit Game"))
            {
                Application.Quit();

                // If running in the Unity editor, stop playing the scene
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#endif
            }
        }
    }
}
