using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetection : MonoBehaviour
{
    [SerializeField] ParticleSystem crashParticle;
    [SerializeField] float delayTime = 0f;
    
    Controller player;

    void Start()
    {
        player = GetComponent<Controller>();    
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIdx = LayerMask.NameToLayer("Floor");

        if (collision.gameObject.layer.Equals(layerIdx))
        {
            crashParticle.Play();
            player.canControl = false;
            Invoke("ReloadScene", delayTime);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
