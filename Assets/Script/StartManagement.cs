using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManagement : MonoBehaviour
{
   public GameObject IngameobjectCanvas ;
   public GameObject Outgameobjectcanvas;
   public GameObject Ingameobject ;


    void Start()
    {
        IngameobjectCanvas.SetActive(false);
        Ingameobject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickTheButton()
    {
        Ingameobject.SetActive(true);
        IngameobjectCanvas.SetActive(true);
        Outgameobjectcanvas.SetActive(false);
        
    }

}
