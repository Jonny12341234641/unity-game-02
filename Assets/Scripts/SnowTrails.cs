using UnityEngine;

public class SnowTrails : MonoBehaviour
{
    [SerializeField] ParticleSystem snowParticles;

    void OnCollisionEnter2D(Collision2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor"); // Assuming "Obstacle" is the name of the obstacle layer
        if (collision.gameObject.layer == layerIndex) 
        {
            snowParticles.Play();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor"); // Assuming "Obstacle" is the name of the obstacle layer
        if (collision.gameObject.layer == layerIndex) 
        {
            snowParticles.Stop();
        }
    }
}
