using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;

    public float timeDiff;
    public bool IsEat;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
           if(Random.Range(0f,2f)>1.5)
            {
                GameObject newpipe = Instantiate(pipe);
                newpipe.transform.position = new Vector3(Random.Range(15, 18), Random.Range(-3f, 5.5f), 0);
                timer = 0;
                /*
                if ()
                {
                    Destroy(newpipe.gameObject);
                }
                else
                {
                    Destroy(newpipe.gameObject, 10.0f);
                }*/
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Eagle")
        {
            IsEat = true;
        }
    }
}
