using System.Collections;
using UnityEngine;

public class MarbleSpawner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject marble;
    public float delayBetweenSpawns;
    [SerializeField] private int numOfMarblesSpawned = 0;

    private IEnumerator marbleSpawnTimer()
    {
        yield return new WaitForSeconds(delayBetweenSpawns);
        numOfMarblesSpawned++;
        Debug.Log("Marble Spawned: " + numOfMarblesSpawned);
        Instantiate(marble, spawnPoint);
        if (numOfMarblesSpawned < 10)
        {
            StartCoroutine(marbleSpawnTimer());
        }
    }

    public void Button()
    {
        StartCoroutine(marbleSpawnTimer());
    }
}