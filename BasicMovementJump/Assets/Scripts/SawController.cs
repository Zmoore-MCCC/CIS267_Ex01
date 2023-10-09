using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawController : MonoBehaviour
{
    public float movementSpeed;
    public float offset;
    private bool moveUp;
    private float startPosY;
    // Start is called before the first frame update
    void Start()
    {
        startPosY = transform.position.y;
        moveUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        moveSaw();
    }

    public void moveSaw()
    {

        if(moveUp)
        {
            //move the saw up
            transform.Translate(Vector2.up * movementSpeed * Time.deltaTime);
        }
        else
        {
            //move the saw down
            transform.Translate(Vector2.down * movementSpeed * Time.deltaTime);
        }

        //determine if the saw needs to move up or move down.
        if(transform.position.y >= startPosY)
        {
            moveUp = false;
        }

        if(transform.position.y <= startPosY - offset)
        {
            moveUp = true;
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Dead");
        }
    }
}
