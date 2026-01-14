using UnityEngine;

public class PowerUpEffect : MonoBehaviour
{
    [SerializeField] ParticleSystem powerUpParticle;

    Controller player;
    int preCount = 0;

    void Start()
    {
        player = GetComponent<Controller>();
    }

    void Update()
    {
        // moi lan ActivatePowerUp duoc chay -> play
        int curCount = player.getActivePowerUpCount();
        if(curCount - preCount > 0)
        {
            powerUpParticle.Play();
        }
        else if(player.getActivePowerUpCount() == 0)
        {
            powerUpParticle.Stop();
        }
        print(player.getActivePowerUpCount());
        preCount = curCount;
    }
}
