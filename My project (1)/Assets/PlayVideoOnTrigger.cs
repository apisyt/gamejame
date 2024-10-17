using UnityEngine;
using UnityEngine.Video;

public class VideoTrigger : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    private bool hasPlayed = false;
    public float duration = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasPlayed) // Sprawdzamy, czy filmik ju¿ by³ odtwarzany
        {
            hasPlayed = true; // Zaznaczamy, ¿e filmik zosta³ odtworzony
            videoPlayer.Play();
        }
    }

    private void Start()
    {
        Destroy(videoPlayer.gameObject);
    }

    private void OnVideoFinished(VideoPlayer vp)
    {
        videoPlayer.Stop(); // Zatrzymujemy filmik po zakoñczeniu
        // Mo¿esz dodaæ inne dzia³ania, które maj¹ siê wykonaæ po zakoñczeniu filmu
    }
}
