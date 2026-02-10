using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    [SerializeField] PowerUpSO[] powerUps;
    PlayerController player;

    SpriteRenderer spriteRenderer;
    float timeLeft;

    void Start()
    {
        player = FindFirstObjectByType<PlayerController>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        timeLeft = powerUps[0].GetTime();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Player"); // Assuming "Player" is the name of the player layer
        if (collision.gameObject.layer == layerIndex && spriteRenderer.enabled == true) 
        {
            spriteRenderer.enabled = false;
            player.ActivatePowerUp(powerUps[Random.Range(0, powerUps.Length)]);
        }
    }

    void Update()
    {
        CountdownTimer();
    }

    void CountdownTimer()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                player.DeactivatePowerUp(powerUps[0]);
            }
        }
    }
}
