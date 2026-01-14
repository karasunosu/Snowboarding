using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finishParticle;
    [SerializeField] float delayTime = 0f;

    [SerializeField] ScoreManager scoreManager;

    bool isFinished;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !isFinished)
        {
            finishParticle.Play();
            scoreManager.AddScore(500);
            isFinished = true;
            Invoke("ReloadScene", delayTime);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
