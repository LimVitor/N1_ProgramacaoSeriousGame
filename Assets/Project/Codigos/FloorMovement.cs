using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private Transform[] floor;
    [SerializeField] private float heigth;

  

    



    public void Start()
    {
        this.enabled = false;
      


    }
    public void floorMovement()
    {
      

        foreach (Transform f in floor)
        {
            this.enabled = true;
           
      
            f.Translate(new Vector2(0, speed * Time.deltaTime));
            if (f.position.y < heigth * -1)
            {
                Destroy(gameObject);
                
            }
        }
    }

    public void Update()
    {
        floorMovement();
       
       
    }
}
