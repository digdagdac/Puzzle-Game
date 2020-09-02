using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI1 : MonoBehaviour
{

    [SerializeField]
    private Slider hpbar;


    public GameObject U2;
    public GameObject U1;

    private float maxHp = 100;



    void Start()
    {
        hpbar.value = (float)Boss1.body / (float)maxHp;

    }


    void Update()
    {


        HandleHp();

        if (Boss1.body == 0)
        {
            U1.gameObject.SetActive(false);
            U2.gameObject.SetActive(true);
        }
    }


    private void HandleHp()
    {
        hpbar.value = (float)Boss1.body / (float)maxHp;
    }
}