using NUnit.Framework;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    [SerializeField] PowerUpSO power;

    Controller player;
    SpriteRenderer spriteRenderer;

    float timeLeft = 0;
    bool isAlive;

    void Start()
    {
        player = FindFirstObjectByType<Controller>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        timeLeft = power.getTime();
        isAlive = true;
    }

    void Update()
    {
        CountdownTimer();
    }

    void CountdownTimer()
    {
        if (!isAlive)
        {
            if(timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;

                if(timeLeft <= 0)
                {
                    player.DeactivatePowerUp(power);
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && isAlive)
        {
            player.ActivatePowerUp(power);
            spriteRenderer.enabled = false;
            isAlive = false;
        }
    }
}
