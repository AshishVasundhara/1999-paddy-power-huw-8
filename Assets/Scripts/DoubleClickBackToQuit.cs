using UnityEngine;

public class DoubleClickBackToQuit : MonoBehaviour
{
    // Time window for double-click detection (in seconds)
    public float doubleClickTime = 0.5f;  // Half a second
    private float lastBackPressTime = 0f;  // Last time the back button was pressed

    void Update()
    {
        // Detect if the back button (Escape) is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Check if the time between this press and the last one is within the doubleClickTime
            if (Time.time - lastBackPressTime <= doubleClickTime)
            {
                QuitApplication();  // Exit the app if it's a double-click
            }
            else
            {
                lastBackPressTime = Time.time;  // Update the last press time
            }
        }
    }

    void QuitApplication()
    {
        // Log a message and quit the application
        Debug.Log("Double-click detected! Exiting application.");

        Application.Quit();
    }
}

