using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightDefibrilatorMove : MonoBehaviour {
    public float movingspeed = 50;
    public Material portaMat;
    float timer;
    // Use this for initialization
    void Start () {

        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            MoveRight();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            MoveLeft();
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            MoveUp();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            MoveDown();
        }

    /*    if (Input.GetKeyDown(KeyCode.Q))
        {
            timer = Time.time;
        }
      */
    }
    public void MoveRight()
    {
        transform.Translate(Vector2.right);
    }
    public void MoveLeft()
    {
        transform.Translate(Vector2.left);
    }
    public void MoveUp()
    {
        transform.Translate(Vector2.up);
    }
    public void MoveDown()
    {
        transform.Translate(Vector2.down);
    }

}
