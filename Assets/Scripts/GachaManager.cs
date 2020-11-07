using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaManager : MonoBehaviour
{
    public GachaDatabase Gachamachine;

    void Start()
    {

    }

    public void Pull()
    {
        int number = Random.Range(1, 1000);
        Debug.Log(number);
        Debug.Log("pulled");
        if (number <= 600)
        {
            GameManager.Instance.Summon(Gachamachine.gachapool[0]);
        }
        if(number <= 950)
        {
            GameManager.Instance.Summon(Gachamachine.gachapool[1]);
        }
        else
        {
            GameManager.Instance.Summon(Gachamachine.gachapool[2]);
        }

   
    }
}
