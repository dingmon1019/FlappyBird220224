using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MkePipe : MonoBehaviour
{
    Rigidbody2D rigid;
    public GameObject secitem;
    public GameObject pipe;
    float timer = 0;
    public float timediff;
    int rand = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if(timer > Random.Range(1f,1.4f))
        {
            GameObject newsect = Instantiate(secitem); 
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(Random.Range(6f,7f), Random.Range(-1f,0.3f), 0);
            if (Random.Range(0f, 1f) > 0.8f)
            {
                newsect.transform.position = new Vector3(newpipe.transform.position.x+Random.Range(3.4f,3.7f), newpipe.transform.position.y + Random.Range(2f, 3f), newpipe.transform.position.z);

            }
            else
            {
                Destroy(newsect);
            }
            

            timer = 0;
            Destroy(newpipe,9.0f);
            Destroy(newsect, 9.0f);

        }


    }

}
