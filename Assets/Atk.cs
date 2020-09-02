using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atk : MonoBehaviour
{
    public int body = 100; //변수 선언
    public int damagePerClick = 10;


    public void OnClick()

    {

    body -= damagePerClick; //coin에 coinperClick만큼 뺀다
        

    }


  


}



