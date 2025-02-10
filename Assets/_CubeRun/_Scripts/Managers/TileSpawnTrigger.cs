using UnityEngine;
using Sirenix.OdinInspector;

public class TileSpawnTrigger : MonoBehaviour
{
    #region Properties and Fields

    [SerializeField] private GameObject[] groundTilePrefabs;

    [Title("Spawner Attributes")]
    [SerializeField] private Vector3 spawnPos;

    #endregion

    private void OnTriggerEnter(Collider other)
    {
        /// Generate random num for tile array indexer.
        int randomIndex = Random.Range(0, groundTilePrefabs.Length - 1);
        /// Spawn Random tile on trigger point.
        Instantiate(groundTilePrefabs[randomIndex], spawnPos, Quaternion.identity);
    }
}
