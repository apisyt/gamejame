using UnityEngine;
using UnityEngine.Video;

public class VideoTrigger : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    private bool hasPlayed = false;
    public float duration = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasPlayed) // Sprawdzamy, czy filmik ju� by� odtwarzany
        {
            hasPlayed = true; // Zaznaczamy, �e filmik zosta� odtworzony
            videoPlayer.Play();
        }
    }

    private void Start()
    {
        Destroy(videoPlayer.gameObject);
    }

    private void OnVideoFinished(VideoPlayer vp)
    {
        videoPlayer.Stop(); // Zatrzymujemy filmik po zako�czeniu
        // Mo�esz doda� inne dzia�ania, kt�re maj� si� wykona� po zako�czeniu filmu
    }
}
