using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public static bool IsItem = false;
    public GameObject upside;
    float Timer=0;
    public float JumpPower;
    public Camera camera;
    Vector2 MousePos;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("IsItem", IsItem);
        Timer += Time.deltaTime;
        if (IsItem && Timer > 5)
        {
           
            IsItem = false;
            rb.gravityScale = 1;
        }
        if (!IsItem)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.up * JumpPower;
            }

        }
        if (IsItem)
        {
            if (Input.GetMouseButton(1))
            {
                MousePos = Input.mousePosition;
                MousePos = camera.ScreenToWorldPoint(MousePos);
                transform.position = new Vector3(0, MousePos.y, 0);

            }
            
        }
     
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(Score.score > Score.bestscore)
        {
            Score.bestscore = Score.score;
        }
        if(other.gameObject == upside)
        {

        }
        else
        {
            if (IsItem)
            {
         
            }
            else
            {
                SceneManager.LoadScene("GameOverScene");
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Item")
        {
            
            Timer = 0;
            IsItem = true;
            rb.gravityScale = 0;
        }
    }
}
