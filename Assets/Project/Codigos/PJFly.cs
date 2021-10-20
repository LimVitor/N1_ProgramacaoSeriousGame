using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PJFly : MonoBehaviour
{
    [SerializeField] private Vector2 FlyForce;
    private Rigidbody2D _rb;
    private Animator _anim;
    [SerializeField] private AsteroidMovement asteroidMovement;
    private bool isDead;
    [SerializeField] private int Score;


    void Start()
    {
        
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

   public void Fly()
    {
        if (isDead)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        asteroidMovement.enabled = true;

        _anim.SetBool("isFlying", true);

        _rb.velocity = Vector2.zero;
        _rb.AddForce(FlyForce, ForceMode2D.Impulse);

        GameController.instance.totalScore += Score;
        GameController.instance.UpdateScoreText();
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Asteroid"))
        {
            Death();
        }

        void Death()
        {
            AsteroidMovement[] allScrolls = FindObjectsOfType<AsteroidMovement>();
            foreach (AsteroidMovement scroll in allScrolls)
            {
                scroll.enabled = false;
                GameController.instance.ShowGameOver();
            }
            isDead = true;
        }



    }


}
