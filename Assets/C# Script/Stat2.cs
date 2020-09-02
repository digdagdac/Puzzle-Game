using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat2 : MonoBehaviour
{
    [SerializeField]
    private Slider hpbar;


    public GameObject O;
    public GameObject X;
    public Image image;

    private float maxHp = 110;



    void Start()
    {
        image.fillAmount = (float)Boss2.body / (float)maxHp;

    }


    void Update()
    {
        if (Boss2.body == 50)
        {
            image.GetComponent<Image>().color = Color.red;
        }

        HandleHp();

        if (Boss2.body == 0)
        {
            X.gameObject.SetActive(false);
            O.gameObject.SetActive(true);
        }
    }


    private void HandleHp()
    {
        image.fillAmount = (float)Boss2.body / (float)maxHp;
    }
}