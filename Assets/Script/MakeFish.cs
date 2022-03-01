using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeFish : MonoBehaviour
{
    public GameObject Fish;

    public float timeDiffF;

    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeDiffF)
        {
            GameObject newpipe = Instantiate(Fish);
            newpipe.transform.position = new Vector3(10, Random.Range(-0.8f, 6.5f), 0);
            timer = 0;
            Destroy(newpipe, 4.0f);
        }
    }
}
