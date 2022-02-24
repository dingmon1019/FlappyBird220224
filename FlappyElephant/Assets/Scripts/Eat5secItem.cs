using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat5secItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "bird")
        {
            Destroy(transform);
        }

    }

}
