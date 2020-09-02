using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat4 : MonoBehaviour
{
    [SerializeField]
    private Slider hpbar;


    public GameObject O;
    public GameObject X;
    public Image image;

    private float maxHp = 130;



    void Start()
    {
        image.fillAmount = (float)Boss4.body / (float)maxHp;

    }


    void Update()
    {

        if (Boss4.body == 60)
        {
            image.GetComponent<Image>().color = Color.red;
        }
        HandleHp();

        if (Boss4.body == 0)
        {
            X.gameObject.SetActive(false);
            O.gameObject.SetActive(true);
        }
    }


    private void HandleHp()
    {
        image.fillAmount = (float)Boss4.body / (float)maxHp;
    }
}