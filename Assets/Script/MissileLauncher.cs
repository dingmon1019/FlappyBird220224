using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLauncher : MonoBehaviour
{
    public GameObject Missile;

    float timer = 0;
    public float timeDiffF;
    
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
            GameObject NewMissile = Instantiate(Missile);
            NewMissile.transform.position = new Vector3(13f, Random.Range(-2f, 5.3f), 0);
            NewMissile.transform.position += Vector3.left*Time.deltaTime*3;
            timer = 0;
            Destroy(NewMissile, 13.0f);
        }
        
    }
}
