using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidControl : AsteroidMovement
{
    [SerializeField] private Vector2 randomHeight;

    void Start()
    {

        onScrollPartRecycled += DoRandomHeight;

        foreach (Transform asteroid in asteroids)
        {
            DoRandomHeight(asteroid);
        }
    }

    void DoRandomHeight(Transform asteroid)
    {
        float randomValue = Random.Range(randomHeight.x, randomHeight.y);
        asteroid.position = new Vector2(asteroid.position.x, randomValue);
    }
    void OnPartRecycled(Transform asteroid)
    {
        DoRandomHeight(asteroid);
    }
}
