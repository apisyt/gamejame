using UnityEngine;

public class InstructionWindow : MonoBehaviour
{
    // Variable to control the visibility of the window
    private bool showWindow = true;

    // Dimensions of the window
    private Rect windowRect = new Rect(Screen.width / 2 - 150, Screen.height / 2 - 75, 300, 150);

    void OnGUI()
    {
        // Show the window if showWindow is true
        if (showWindow)
        {
            // Create a window with the title "Instructions"
            windowRect = GUI.Window(0, windowRect, DrawWindow, "Instructions");
        }
    }

    // Method to draw the contents of the window
    void DrawWindow(int windowID)
    {
        // Create a label with instructions text
        GUI.Label(new Rect(10, 30, windowRect.width - 20, 30), "To move use W A S D");

        // Create a red "X" button in the top right corner of the window
        if (GUI.Button(new Rect(windowRect.width - 30, 10, 20, 20), "X"))
        {
            // Close the window when the button is clicked
            showWindow = false;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            // Toggle the button visibility
            showWindow = false;
        }

        // Allow the window to be draggable (optional)
        GUI.DragWindow(new Rect(0, 0, windowRect.width, windowRect.height));
    }
}
