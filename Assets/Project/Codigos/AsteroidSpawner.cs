using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] private GameObject asteroid;
    //private int _asteroid;

    [SerializeField] private float maxSpawnRateInSeconds;

    void Start()
    {
        Invoke("SpawnAsteroid", maxSpawnRateInSeconds);
        //_asteroid = asteroid.Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAsteroid()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(-1, 0));

        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        // foreach (Transform a in asteroid)

        GameObject anAsteroid = (GameObject)Instantiate (asteroid);

        anAsteroid.transform.position = new Vector2(max.x, Random.Range(min.y, max.y));

           
        
        Debug.Log("Kabum");
    }
}
