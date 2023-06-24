using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float speed;
    private bool eating;

    public int damage;

    public int health;

    private void Update()
    {
        if (health <= 0)
            Die();
    }

    private void FixedUpdate()
    {
        if(!eating)
            Move();
    }

    private void Move()
    {
        transform.position += Vector3.left * speed *Time.fixedDeltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Plant")
        {
            eating = true;
        }
        else if(collision.tag=="Bullet")
        {
            health -= collision.GetComponent<Pea>().damage;
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag=="Plant")
        {
            collision.GetComponent<Plant>().health -= damage;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag=="Plant")
        {
            eating = false;

        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
