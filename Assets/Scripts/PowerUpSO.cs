using UnityEngine;

[CreateAssetMenu(fileName = "PowerUpSO", menuName = "Scriptable Objects/PowerUpSO")]
public class PowerUpSO : ScriptableObject
{
    [SerializeField] string PowerUpType;
    [SerializeField] float valueChange;
    [SerializeField] float time;
}
