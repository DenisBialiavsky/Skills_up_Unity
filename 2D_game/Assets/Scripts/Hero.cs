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

    public bool facingright = true;

    public Image[] hearts;
    public Sprite fullheart;
    public Sprite emptyheart;

    public GameObject panel;

    private Rigidbody2D rig;
    
    public Joystick joystick;

    private Vector2 moveInput;
    private Vector2 moveVelocity;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
        moveInput = new Vector2(joystick.Horizontal, joystick.Vertical);
        moveVelocity = moveInput.normalized * speed;

        if (!facingright && moveInput.x > 0)
        {
            Flip();
        }
        else if(facingright && moveInput.x < 0)
        {
            Flip();
        }
    }
    private void FixedUpdate()
    {
        rig.MovePosition(rig.position + moveVelocity * Time.fixedDeltaTime);

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

    private void Flip()
    {
        facingright = !facingright;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

}
