using Sirenix.OdinInspector;
using UnityEngine;

public class FloorTileMovement : MonoBehaviour
{
    #region Properties and Fields

    [Title("Tile movement Fields on z axis")]
    [SerializeField] private float propSpeed;
    [SerializeField] private float destroyRange;

    #endregion


    private void Update()
    {
        MovePlatform();
        DestroyPlatform();
    }

    private void MovePlatform()
    {
        transform.Translate(Vector3.back * propSpeed * Time.deltaTime);
    }

    private void DestroyPlatform()
    {
        if (transform.position.z <= destroyRange)
        {
            Destroy(gameObject);
        }
    }
}
