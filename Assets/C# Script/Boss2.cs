using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss2 : MonoBehaviour
{
    void Start()
    {
       // StartCoroutine(NextLevel()); //넥스트 레벨 함수 시작
    }
    private bool boss2;

    public GameObject Boss3;
    public static int body = 110;
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
            Boss3.gameObject.SetActive(true);
        }
    }

   //ienumerator nextlevel()
   // {

   //     yield return null;
   // }
}
