using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject playertemplate;

    public GameObject player;

    public Text text;

    public List<GameObject> collection = new List<GameObject>();

    public List<GameObject> top = new List<GameObject>();

    public List<GameObject> jg = new List<GameObject>();

    public List<GameObject> mid = new List<GameObject>();

    public List<GameObject> bot = new List<GameObject>();

    public List<GameObject> sup = new List<GameObject>();

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
        Spawn(set.playerpool[random]);
        
    }

    public void Spawn(PlayerData data)
    {
        player = GameObject.Instantiate(playertemplate);
  
        var playerinfo = player.GetComponent<Player>();
        var image = player.GetComponent<Sprite>();
        var renderer = player.GetComponent<SpriteRenderer>();
        image = data.sprite;
        renderer.sprite = data.sprite;
        playerinfo.stats = data;
        //Rewrite(data);
        collection.Add(player);
    }


    /*public void Rewrite(PlayerData data)
    {

        text.text = "You rolled " + data.rarity + " star: " + data.name;
    }*/
}
