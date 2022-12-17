using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private float moveInput;
    private bool facingRight = true;
    public Animator animator;
    public float health;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHP;
    public Sprite halfHP;
    public Sprite lowHP; 
    

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }
        for(int i=0; i < hearts.Length; i++)
        {
            if(i < Mathf.RoundToInt(health))
            {
                hearts[i].sprite = fullHP;
            }
            else
            {
                hearts[i].sprite = lowHP;
            }
        }
        
        moveInput = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(moveInput));
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if(facingRight == false && moveInput > 0) // Если игрок смотрит влево и нажата клавиша для движения влево
        {
            Flip();
        }
        else if(facingRight == true && moveInput < 0) // Если игрок смотрит вправо и нажата клавиша для движения вправо
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *=-1;
        transform.localScale = scaler;
    }
   
}