using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeShade : MonoBehaviour
{
    public GameObject shade;

    public float timeDiffS;

    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeDiffS)
        {
            GameObject newpipe = Instantiate(shade);
            newpipe.transform.position = new Vector3(6, Random.Range(-0.8f, 6.5f), 0);
            timer = 0;
            Destroy(newpipe, 2.0f);
        }
    }
}
