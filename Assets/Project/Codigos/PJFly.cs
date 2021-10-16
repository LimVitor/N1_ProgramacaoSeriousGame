using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJFly : MonoBehaviour
{
    [SerializeField] private Vector2 FlyForce;
    private Rigidbody2D _rb;
    private Animator _anim;

    void Start()
    {
        Application.targetFrameRate = 60;
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

   public void Fly()
    {
        _rb.velocity = Vector2.zero;
        _rb.AddForce(FlyForce, ForceMode2D.Impulse);
        _anim.SetBool("isFlying", true);
    }
    void Update()
    {
        
    }
}
