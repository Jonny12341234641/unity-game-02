using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float restartDelay = 1f;
    [SerializeField] ParticleSystem FinishParticles;
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        int layerIndex = LayerMask.NameToLayer("Player"); // Assuming "Player" is the name of the player layer
        if (other.gameObject.layer == layerIndex) 
        {
            FinishParticles.Play();
            Debug.Log("Finish Line Crossed by: " + other.name);
            Invoke("ReloadScene", restartDelay);
            //SceneManager.LoadScene(0); // Reloads the first scene (index 0)
        }
    }

    void ReloadScene() 
    {
        SceneManager.LoadScene(0); // Reloads the first scene (index 0)
    }
}
