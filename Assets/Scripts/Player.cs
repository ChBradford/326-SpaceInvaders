using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public GameObject bullet;

  public Transform shottingOffset;
    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        //Debug.Log("Bang!");

        Destroy(shot, 3f);

      }
      //movement keys
       if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(90 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(90 * Time.deltaTime, 0, 0);
        }
    }
}
