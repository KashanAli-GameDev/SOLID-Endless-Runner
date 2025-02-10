using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/PlayerAttributes", fileName = "PlayerAttributes")]
public class PlayerAttributesSO : ScriptableObject
{
    [Title("Player Attributes Fields")]
    public float Speed = 5;
    public float JumpForce = 5;
}
