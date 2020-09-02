using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss3 : MonoBehaviour
{
   
    private bool boss3;

    public GameObject Boss4;
    public static int body = 120;
    public int damagePerClick = 10;




    public void OnClick()
    {

        body -= damagePerClick; //coin에 coinperClick만큼 뺀다  
        Debug.Log("10 Damge!");
    }




    void Update()
    {
        if (body == 0)
        {
            gameObject.SetActive(false);
            Boss4.gameObject.SetActive(true);
        }
    }

   
}
