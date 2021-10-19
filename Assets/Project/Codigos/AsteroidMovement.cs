using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AsteroidMovement : MonoBehaviour
{
    [SerializeField] protected Transform[] asteroids;
    [SerializeField] private Vector2 speed;
    [SerializeField] private float width;
    private int _asteroidLength;
    protected Action<Transform> onScrollPartRecycled;
    void Awake()
    {
        _asteroidLength = asteroids.Length;
    }

    // Update is called once per frame
    void Update()
    {

        foreach (Transform a in asteroids)
        {
            a.Translate(speed * Time.deltaTime);

            if (a.position.x < width * _asteroidLength / 2 * -1)
            {
                a.Translate(new Vector2(_asteroidLength * width, 0));
                onScrollPartRecycled?.Invoke(a);
            }
        }
    }
}
