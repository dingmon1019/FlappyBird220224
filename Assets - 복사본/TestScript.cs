using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject TestSquare;
    // Start is called before the first frame update
    void Start()
    {
       GameObject NewGameObject= Instantiate(TestSquare);
       NewGameObject.tag="Player";
       NewGameObject.layer=LayerMask.NameToLayer("Water");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
