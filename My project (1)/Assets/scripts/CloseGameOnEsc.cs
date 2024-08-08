using UnityEngine;
using UnityEngine.UIElements;

public class CloseGameOnEsc : MonoBehaviour
{
    void Update()
    {
        // Check if the Esc key was pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Close the game
            Application.Quit();
            

            // If running in the Unity editor, stop playing the scene
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }
    }
}
