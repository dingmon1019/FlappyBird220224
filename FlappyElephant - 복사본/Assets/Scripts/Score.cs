using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static int score=0;//static 사용 이유: instant를 만들지 않고 클래스 밖에서 해당 변수를 사용 가능
    // Start is called before the first frame update
    public static int bestscore = 0;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "Score: " + score.ToString();
        
    }
}
