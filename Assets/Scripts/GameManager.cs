using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameManager>();
            }

            return _instance;
        }
    }

    public void Summon(PlayerPoolDatabase set)
    {
        int random = Random.Range(0, set.playerpool.Length);
        Debug.Log("oof");
    }
}
