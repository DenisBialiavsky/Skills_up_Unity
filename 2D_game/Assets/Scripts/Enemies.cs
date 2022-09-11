using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemies : MonoBehaviour
{

    public float speed;

    public Vector3 positions;
    public Vector3 minpos;
    public Vector3 maxpos;

    void Update()
    {

        positions = new Vector3(Random.Range(minpos.x, maxpos.x), Random.Range(minpos.y, maxpos.y), positions.z);
        transform.position = Vector3.MoveTowards(transform.position, positions * Time.deltaTime, speed);
        
        
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        Destroy(gameObject);
    //    }
    //}

}
