using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UnityEngine;
using UnityEngine.UI;
    
    public class Stat : MonoBehaviour
{
    [SerializeField]
    private Slider hpbar;

    
    public GameObject O;
    public GameObject X;
    public Image image;
    

    private float maxHp = 100;



    void Start()
    {
       image.fillAmount = (float)Boss1.body / (float)maxHp;

    }


    void Update()
    {

    if ( Boss1.body == 50)
        {
            image.GetComponent<Image>().color = Color.red;
        }
        HandleHp();

        if (Boss1.body == 0)
        {
            X.gameObject.SetActive(false);
            O.gameObject.SetActive(true);
        }

        
    }


    private void HandleHp()
    {
        image.fillAmount = (float)Boss1.body / (float)maxHp;
    }
}