using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 initialPosition;
    public int birdSpeed;
    public bool firstShot = true;
    
    public static int count;
    public void Awake()
    {
        initialPosition = transform.position;
    }

    public void OnMouseUp()
    {
        if (firstShot)
        {
            Vector2 springForce = initialPosition - transform.position;
            GetComponent<Rigidbody2D>().gravityScale = 1;
            GetComponent<Rigidbody2D>().AddForce(springForce * birdSpeed);
            Invoke("destroyOBJ", 10f);
            firstShot = false;
            ShootSling.shoot = true;
        }
    }

    public void OnMouseDrag()
    {
        if (firstShot)
        {
            Vector3 DragPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(DragPosition.x, DragPosition.y);
        }
    }

    void destroyOBJ()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            count++;
            Destroy(collision.gameObject);
        }
    }
}
