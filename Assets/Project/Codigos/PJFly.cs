using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJFly : MonoBehaviour
{
    [Header("PJ")]
    [SerializeField] private Vector2 FlyForce;
    private Rigidbody2D _rb;
    private Animator _anim;

    [SerializeField] private FloorMovement floorMovement;

    void Start()
    {
       
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

   public void Fly()
    {
        floorMovement.enabled = true;
        _rb.velocity = Vector2.zero;
        _rb.AddForce(FlyForce, ForceMode2D.Impulse);
        _anim.SetBool("isFlying", true);
    }

  


   

}
