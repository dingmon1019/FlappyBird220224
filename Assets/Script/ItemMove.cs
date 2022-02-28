using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMove : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * Speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(transform.gameObject);
    }
}
