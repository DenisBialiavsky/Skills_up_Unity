using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hero : MonoBehaviour
{
    public float speed = 0.1f;
    public float health;
    public int current_hearts;
    public float dmg;

    public Image[] hearts;
    public Sprite fullheart;
    public Sprite emptyheart;

    public GameObject panel;

    private void FixedUpdate()
    {
        transform.position += new Vector3(speed, 0, 0) * Input.GetAxis("Horizontal");
        transform.position += new Vector3(0, speed, 0) * Input.GetAxis("Vertical");

        GetComponent<SpriteRenderer>().flipX = false;

        if (health > current_hearts)
        {
            health = current_hearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < Mathf.RoundToInt(health))
            {
                hearts[i].sprite = fullheart;
            }
            else
            {
                hearts[i].sprite = emptyheart;
            }
            if (i < current_hearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health -= dmg;

            if (health <= 0)
            {
                hearts[0].sprite = emptyheart;
                Destroy(gameObject);
                panel.SetActive(true);
            }          
        }
    }

}
