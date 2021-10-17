using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    [Header("Floor")]
    [SerializeField] private int speed;
    [SerializeField] private Transform[] floor;
    [SerializeField] private float heigth;
    public void Update()
    {
        foreach (Transform f in floor)
        {
            f.Translate(new Vector2(0, speed * Time.deltaTime));
            if (f.position.y < heigth * -1)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
