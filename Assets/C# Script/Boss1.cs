using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;


public class Boss1 : MonoBehaviour
{
  
    private bool boss1;
   // private int i = 0;

    public GameObject Boss2;

    public static int body = 100;
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
                Boss2.gameObject.SetActive(true);
            }
    }

   
} 
        
    

