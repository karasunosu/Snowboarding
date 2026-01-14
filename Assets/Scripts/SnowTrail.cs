using UnityEngine;

public class SnowTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem trailParticle;

    int floorLayerIndex = 0;

    void Start()
    {
        floorLayerIndex = LayerMask.NameToLayer("Floor");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer.Equals(floorLayerIndex))
        {
            trailParticle.Play();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer.Equals(floorLayerIndex))
        {
            trailParticle.Stop();
        }
    }
}
