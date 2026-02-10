using Unity.VisualScripting;
using UnityEngine;

public class CharSelectManager : MonoBehaviour
{
    [SerializeField] GameObject scoreCanvas;
    [SerializeField] GameObject dinoSprite;

    [SerializeField] GameObject frogSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      Time.timeScale = 0;  
    }

    // Update is called once per frame
    void BeginGame()
    {
       Time.timeScale = 1f;
       scoreCanvas.SetActive(true);
       gameObject.SetActive(false);
    }

    public void ChooseDino()
    {
        dinoSprite.SetActive(true);
        BeginGame();
    }
}
