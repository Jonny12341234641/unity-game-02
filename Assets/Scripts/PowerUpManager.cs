using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    [SerializeField] PowerUpSO[] powerUps;
    PlayerController player;

    void Start()
    {
        player = FindFirstObjectByType<PlayerController>();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
                int layerIndex = LayerMask.NameToLayer("Player"); // Assuming "Player" is the name of the player layer
        if (collision.gameObject.layer == layerIndex) 
        {
            //activate the power up
            player.ActivatePowerUp(powerUps[Random.Range(0, powerUps.Length)]);
        }
    }
}
