using Unity.VectorGraphics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDitector : MonoBehaviour
{
    [SerializeField] float restartDelay = 1f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor"); // Assuming "Obstacle" is the name of the obstacle layer
        if (collision.gameObject.layer == layerIndex) 
        {
            Debug.Log("Crash Detected");
            Invoke("ReloadScene", restartDelay);
        }
    }
    void ReloadScene() 
    {
        SceneManager.LoadScene(0); // Reloads the first scene (index 0)
    }
}
