using System.Collections;
using UnityEngine;

public class MarbleSpawner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject marble;
    public float delayBetweenSpawns;
    [SerializeField] private int numOfMarblesSpawned = 0;

    private void Start()
    {
        StartCoroutine(marbleSpawnTimer());
    }

    private IEnumerator marbleSpawnTimer()
    {
        yield return new WaitForSeconds(delayBetweenSpawns);
        numOfMarblesSpawned++;
        Debug.Log("Marble Spawned: " + numOfMarblesSpawned);
        Instantiate(marble, spawnPoint);
        if (numOfMarblesSpawned < 11)
        {
            StartCoroutine(marbleSpawnTimer());
        }
    }
}