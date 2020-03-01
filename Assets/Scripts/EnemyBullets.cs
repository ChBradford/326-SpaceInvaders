using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] //technique for making sure there isn't a null reference during runtime if you are going to use get component
public class EnemyBullets : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;
    public float speed = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        Fire();
    }

    // Update is called once per frame
    private void Fire()
    {
        myRigidbody2D.velocity = Vector2.down * speed;
        //Debug.Log("Wwweeeeee");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //enemy bullets only will destroy players and barriers.
        if(other.tag == "Player")
        {
            Destroy(gameObject);
            Lives.lifecount -= 1;
            if(Lives.lifecount == 0)
            {
                Destroy(other.gameObject);
            }
        }
        if(other.tag == "Barrier")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
    }
