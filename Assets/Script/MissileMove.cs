using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMove : MonoBehaviour
{
     public float SpeedX;
     public float RangeY;
     public float SinCycleSpeed;

     
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     transform.position += new Vector3(-1.0f*SpeedX,Mathf.Sin(Time.time*SinCycleSpeed)*RangeY,1f) * Time.deltaTime ;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Eagle")
        Destroy(gameObject);
    }
}
