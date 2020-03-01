using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform enemies;
    public float speed = 1.0f;
    public int count;
    public int startercount;
    public bool destinedRight = true;
    public GameObject Bullet;

    // Start is called before the first frame update
    void Start()
    {
        //invoke start of movement and save start count (32 enemies)
        InvokeRepeating("Move", 0.1f, 0.45f);
        enemies = GetComponent<Transform>();
        startercount = enemies.childCount;
    }
    //For movement of enemies
    void Move()
    {
        //movement and reverse + lower enemies when reaching walls
        enemies.position += Vector3.right * speed;
        foreach (Transform Enemy in enemies)
        {
            if (Enemy.position.x > 10.5 || Enemy.position.x < -10.5)
            {
                speed = -speed;
                enemies.position += Vector3.down * 0.5f;
                return;
            }
            //1 in 50 chance of firing
            if (Random.Range(0, 50) == 0)
            {
                GameObject shot = Instantiate(Bullet, Enemy.position, Quaternion.identity);
            }
        }
    }
    void Update()
    {
        //if count of enemies is going down, speed up
        count = enemies.childCount;
        if (startercount != count)
        {
            startercount = count;
            speed *= 1.05f;
        }
    }
}
