using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss5 : MonoBehaviour
{
   
    private bool boss5;


    public static int body = 140;
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
            
        }
    }

   
}
