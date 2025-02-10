using System.Collections;
using UnityEngine;

public class HurdleDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(StringUtility.HurdleTag))
        {
            LevelManager.Instance.GameOver();
        }
    }
}
