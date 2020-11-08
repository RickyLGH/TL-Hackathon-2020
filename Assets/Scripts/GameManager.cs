using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject playertemplate;

    public GameObject player;

    public TextMeshProUGUI text;

    public GameObject starthree;
    
    public GameObject starfour;

    public GameObject starfive;

    public GameObject roletop;

    public GameObject rolejgl;

    public GameObject rolemid;

    public GameObject rolebot;

    public GameObject rolesupp;

    public GameObject hundredthieves;

    public GameObject tl;

    public GameObject tsm;

    public GameObject eg;

    public GameObject gg;

    public GameObject fq;

    public GameObject clg;

    public GameObject cnine;

    public GameObject imt;

    public GameObject dg;

    public List<GameObject> collection = new List<GameObject>();

    public List<GameObject> top = new List<GameObject>();

    public List<GameObject> jg = new List<GameObject>();

    public List<GameObject> mid = new List<GameObject>();

    public List<GameObject> bot = new List<GameObject>();

    public List<GameObject> supp = new List<GameObject>();

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
        Rewrite(data);
        var playerinfo = player.GetComponent<Player>();
        var image = player.GetComponent<Sprite>();
        var renderer = player.GetComponent<SpriteRenderer>();
        image = data.sprite;
        renderer.sprite = data.sprite;
        renderer.size -= new Vector2(.05f, .01f);
        playerinfo.stats = data;
        collection.Add(player);

        if(data.team == "liquid")
        {
            dg.SetActive(false);
            fq.SetActive(false);
            imt.SetActive(false);
            eg.SetActive(false);
            gg.SetActive(false);
            hundredthieves.SetActive(false);
            cnine.SetActive(false);
            clg.SetActive(false);
            tsm.SetActive(false);
            tl.SetActive(true);
        }
        if (data.team == "tsm")
        {
            dg.SetActive(false);
            fq.SetActive(false);
            imt.SetActive(false);
            eg.SetActive(false);
            gg.SetActive(false);
            hundredthieves.SetActive(false);
            cnine.SetActive(false);
            clg.SetActive(false);
            tl.SetActive(false);
            tsm.SetActive(true);
        }
        if (data.team == "clg")
        {
            dg.SetActive(false);
            fq.SetActive(false);
            imt.SetActive(false);
            eg.SetActive(false);
            gg.SetActive(false);
            hundredthieves.SetActive(false);
            cnine.SetActive(false);
            tsm.SetActive(false);
            tl.SetActive(false);
            clg.SetActive(true);
        }
        if (data.team == "c9")
        {
            dg.SetActive(false);
            fq.SetActive(false);
            imt.SetActive(false);
            eg.SetActive(false);
            gg.SetActive(false);
            hundredthieves.SetActive(false);
            clg.SetActive(false);
            tsm.SetActive(false);
            tl.SetActive(false);
            cnine.SetActive(true);
        }
        if (data.team == "100t")
        {
            dg.SetActive(false);
            fq.SetActive(false);
            imt.SetActive(false);
            eg.SetActive(false);
            gg.SetActive(false);
            cnine.SetActive(false);
            clg.SetActive(false);
            tsm.SetActive(false);
            tl.SetActive(false);
            hundredthieves.SetActive(true);
        }
        if (data.team == "gg")
        {
            dg.SetActive(false);
            fq.SetActive(false);
            imt.SetActive(false);
            eg.SetActive(false);
            hundredthieves.SetActive(false);
            cnine.SetActive(false);
            clg.SetActive(false);
            tsm.SetActive(false);
            tl.SetActive(false);
            gg.SetActive(true);
        }
        if (data.team == "eg")
        {
            dg.SetActive(false);
            fq.SetActive(false);
            imt.SetActive(false);
            gg.SetActive(false);
            hundredthieves.SetActive(false);
            cnine.SetActive(false);
            clg.SetActive(false);
            tsm.SetActive(false);
            tl.SetActive(false);
            eg.SetActive(true);
        }
        if (data.team == "imt")
        {
            dg.SetActive(false);
            fq.SetActive(false);
            eg.SetActive(false);
            gg.SetActive(false);
            hundredthieves.SetActive(false);
            cnine.SetActive(false);
            clg.SetActive(false);
            tsm.SetActive(false);
            tl.SetActive(false);
            imt.SetActive(true);
        }
        if (data.team == "flyquest")
        {
            dg.SetActive(false);
            imt.SetActive(false);
            eg.SetActive(false);
            gg.SetActive(false);
            hundredthieves.SetActive(false);
            cnine.SetActive(false);
            clg.SetActive(false);
            tsm.SetActive(false);
            tl.SetActive(false);
            fq.SetActive(true);
        }
        if (data.team == "dignitas")
        {
            fq.SetActive(false);
            imt.SetActive(false);
            eg.SetActive(false);
            gg.SetActive(false);
            hundredthieves.SetActive(false);
            cnine.SetActive(false);
            clg.SetActive(false);
            tsm.SetActive(false);
            tl.SetActive(false);
            dg.SetActive(true);
        }
        if (data.rarity == 3)
        {
            starfour.SetActive(false);
            starfive.SetActive(false);
            starthree.SetActive(true);
        }
        if (data.rarity == 4)
        {
            starthree.SetActive(false);
            starfive.SetActive(false);
            starfour.SetActive(true);
        }
        if (data.rarity == 5)
        {
            starthree.SetActive(false);
            starfour.SetActive(false);
            starfive.SetActive(true);
        }
        if (data.position == "top")
        {
            rolesupp.SetActive(false);
            rolebot.SetActive(false);
            rolemid.SetActive(false);
            rolejgl.SetActive(false);
            roletop.SetActive(true);
            top.Add(player);
        }
        if (data.position == "jgl")
        {
            roletop.SetActive(false);
            rolesupp.SetActive(false);
            rolebot.SetActive(false);
            rolemid.SetActive(false);
            rolejgl.SetActive(true);
            jg.Add(player);
        }
        if (data.position == "mid")
        {
            roletop.SetActive(false);
            rolesupp.SetActive(false);
            rolebot.SetActive(false);
            rolejgl.SetActive(false);
            rolemid.SetActive(true);
            mid.Add(player);
        }
        if (data.position == "bot")
        {
            roletop.SetActive(false);
            rolesupp.SetActive(false);
            rolemid.SetActive(false);
            rolejgl.SetActive(false);
            rolebot.SetActive(true);
            bot.Add(player);
        }
        if (data.position == "supp")
        {
            roletop.SetActive(false);
            rolebot.SetActive(false);
            rolemid.SetActive(false);
            rolejgl.SetActive(false);
            rolesupp.SetActive(true);
            supp.Add(player);
        }
    }


    public void Rewrite(PlayerData data)
    {

        text.text = "You rolled " + data.rarity + " star: " + data.name;
    }
}
