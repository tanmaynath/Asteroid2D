using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    #region fields
    [SerializeField]
    List<SpawnPoint> spawnPoints;// = new List<SpawnPoint>();
    [SerializeField]
    GameObject asteroidPrefab;
    GameObject asteroid;
    #endregion

    private void Start()
    {
        SpawnAsteroids();
        //Object.Instantiate(asteroid, spawnPoints[0].GetPosition);
    }

    private void SpawnAsteroids()
    {
        foreach(var point in spawnPoints)
        {
           asteroid = Instantiate(asteroidPrefab, point.GetPosition, Quaternion.identity);
           asteroid.GetComponent<AsteroidController>().forceDirection = point.GetDirection;
        }
    }
}
