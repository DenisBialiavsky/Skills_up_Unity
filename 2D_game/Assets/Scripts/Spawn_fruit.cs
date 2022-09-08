using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_fruit : MonoBehaviour
{
    public GameObject prefab;

    public Vector2 minPos;
    public Vector2 maxPos;
    
    private float spawn_delay = 1.00f;
    
    private IEnumerator Start()
    {
        int spawn_count = 5;

        while (spawn_count > 0)
        {
            spawn_count--;
            var pos = new Vector2(Random.Range(minPos.x, maxPos.x), Random.Range(minPos.y, maxPos.y));
            Instantiate(prefab, pos, Quaternion.identity);
            yield return new WaitForSeconds(spawn_delay);
        }
    }
   
}
