using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BirdJump : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool Is5sec = false;

    float timer = 0;
    Rigidbody2D rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        Pipemove.pipespeed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigid.velocity = Vector2.up * 5;
            GetComponent<AudioSource>().Play();
        }
        if (Pipemove.pipespeed == 8)
        {
            timer += Time.deltaTime;
            if (timer > 5)
            {
                Is5sec = false;
                Pipemove.pipespeed = 2;
                timer = 0;
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Score.score > Score.bestscore)
        {
            Score.bestscore = Score.score;
        }
        if (Is5sec)
        {
            
        }
        else
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "item") {
            Debug.Log("Triggered");
            Is5sec = true;
            Pipemove.pipespeed = 8; }
        
    }

}
