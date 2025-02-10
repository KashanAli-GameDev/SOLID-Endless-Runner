using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(StringUtility.PlayerTag))
        {
            LevelManager.Instance.GameOver();
        }
    }
}
