using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJFly : MonoBehaviour
{
    [SerializeField] private Vector2 FlyForce;
    private Rigidbody2D _rb;

    void Start()
    {
        Application.targetFrameRate = 60;
        _rb = GetComponent<Rigidbody2D>();
    }

   public void Fly()
    {
        _rb.velocity = Vector2.zero;
        _rb.AddForce(FlyForce, ForceMode2D.Impulse);
    }
    void Update()
    {
        
    }
}
