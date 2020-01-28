using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDefibrilatorMove : MonoBehaviour {
    public float movingspeed = 50;
    public Material portaMat;
    float timer;
    private Rigidbody2D myRigidbody;
    // Use this for initialization
    void Start () {

    
    }
   
    // Update is called once per frame
    void Update()
    {
   

        //
        if (Input.GetKeyDown(KeyCode.D))
        {
            MoveRight1();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveLeft1();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            MoveUp1();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            MoveDown1();
        }
    }
    
    public void MoveRight1()
    {
        transform.Translate(Vector2.right);
       
    }
    public void MoveLeft1()
    {

        transform.Translate(Vector2.left);
    }
    public void MoveUp1()
    {
        transform.Translate(Vector2.up);
    }
    public void MoveDown1()
    {
        transform.Translate(Vector2.down);
    }
}
