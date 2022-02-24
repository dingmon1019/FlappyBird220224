using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "bird" && BirdJump.Is5sec)
        {
            Debug.Log("Ãæµ¹");
            rigid.AddForce(new Vector2(3, 50), ForceMode2D.Impulse);
        }
    }
}
