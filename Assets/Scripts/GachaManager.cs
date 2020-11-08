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
        if(GameManager.Instance.player != null)
        {
            GameManager.Instance.player.SetActive(false);
        }

        int number = Random.Range(1, 1000);

        if (number <= 600)
        {
            GameManager.Instance.Summon(Gachamachine.gachapool[0]);
        }
        else if(number <= 950)
        {
            GameManager.Instance.Summon(Gachamachine.gachapool[1]);

        }
        else
        {
            GameManager.Instance.Summon(Gachamachine.gachapool[2]);
        }
   
    }
}
