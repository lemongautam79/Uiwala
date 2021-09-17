using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightleft : MonoBehaviour
{ 
    public bool movingleft = false;
    public bool movingright = false;
    public bool movingup = false;
    public bool movingdown = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(movingleft)
            {
            left();
            }
        if (movingright)
        {
            right();
        }
        if (movingup)
        {
            up();
        }
        if (movingdown)
        {
            down();
        }
        

    }
    public void TriggerLeft(bool canMove)
    {
        movingleft = canMove;
    }
    public void TriggerRight(bool canMove)
    {
        movingright = canMove;
    }
    public void TriggerUp(bool canMove)
    {
        movingup = canMove;
    }
    public void Triggerdown(bool canMove)
    {
        movingdown = canMove;
    }

    public void left()
    {
        this.transform.position += new Vector3(-50f, 0f, 0f) * Time.deltaTime;
    }
    public void right()
    {
        this.transform.position += new Vector3(50f, 0f, 0f) * Time.deltaTime;
    }
    public void up()
    {
        this.transform.position += new Vector3(0f, 50f, 0f) * Time.deltaTime;
    }
    public void down()
    {
        this.transform.position += new Vector3(-0f, -50f, 0f) * Time.deltaTime;
    }

}
