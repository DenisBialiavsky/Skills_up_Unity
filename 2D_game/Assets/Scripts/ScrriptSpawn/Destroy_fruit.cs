using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_fruit : MonoBehaviour
{
  
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
