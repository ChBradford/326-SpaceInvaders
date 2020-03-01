using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] //technique for making sure there isn't a null reference during runtime if you are going to use get component
public class Bullet : MonoBehaviour
{
  private Rigidbody2D myRigidbody2D;
  public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
      myRigidbody2D = GetComponent<Rigidbody2D>();
      Fire();
    }

    // Update is called once per frame
    private void Fire()
    {
      myRigidbody2D.velocity = Vector2.up * speed; 
      //Debug.Log("Wwweeeeee");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //destroy barrier on hit
        if(other.tag == "Barrier")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        //top to bottom of enemy list
        if(other.tag == "RedEnemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Scorekeep.score += 40;
        }
        if (other.tag == "BlueEnemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Scorekeep.score += 30;
        }
        if (other.tag == "GreenEnemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Scorekeep.score += 20;
        }
        if (other.tag == "PurpleEnemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Scorekeep.score += 10;
        }

    }
}
