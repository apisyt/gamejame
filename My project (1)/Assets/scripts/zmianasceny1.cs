using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CutsceneTrigger : MonoBehaviour
{
    public VideoPlayer videoPlayer;  // Reference to the VideoPlayer component
    public string nextSceneName;     // The name of the next scene to load after the cutscene

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Start playing the cutscene
            videoPlayer.Play();

            // Subscribe to the VideoPlayer's loopPointReached event to know when the video is finished
            videoPlayer.loopPointReached += EndReached;
        }
    }

    void EndReached(VideoPlayer vp)
    {
        // Unsubscribe from the event to prevent it from being called multiple times
        videoPlayer.loopPointReached -= EndReached;

        // Load the next scene
        SceneManager.LoadScene(nextSceneName);
    }
}