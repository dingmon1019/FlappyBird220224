using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    // Start is called before the first frame update
    public static int life = 2;

    void Start()
    {
        life = 2;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = life.ToString();
    }
}
