using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static int score=0;//static ��� ����: instant�� ������ �ʰ� Ŭ���� �ۿ��� �ش� ������ ��� ����
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