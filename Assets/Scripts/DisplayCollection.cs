using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayCollection : MonoBehaviour
{
    public Image images;
   
    public TextMeshProUGUI list3;
    public TextMeshProUGUI list4;
    public TextMeshProUGUI list5;
    
    List<Sprite> spritelist = new List<Sprite>();

    List<string> threenames = new List<string>();
    List<string> fournames = new List<string>();
    List<string> fivenames = new List<string>();

    public void Start()
    {
       
    }

    public void OnEnable()
    {
        foreach(GameObject p in GameManager.Instance.collection)
        {
            var pro = p.GetComponent<Player>();
            
            if(pro.stats.rarity == 3)
            {
                threenames.Add(pro.stats.name);
            }
            if (pro.stats.rarity == 4)
            {
                fournames.Add(pro.stats.name);
            }
            if (pro.stats.rarity == 5)
            {
                fivenames.Add(pro.stats.name);
            }
            //spritelist.Add(data.sprite);
        }

        /*foreach(Sprite sprite in spritelist)
        {
            Instantiate(sprite);
        }*/

        foreach(string name in threenames)
        {
            list3.text = list3.text + " " + name;
        }


        foreach (string name in fournames)
        {
            list4.text = list4.text + " " + name;
        }


        foreach (string name in fivenames)
        {
            list5.text = list5.text + " " + name;
        }
    }

    public void OnDisable()
    {
        threenames.Clear();
        fournames.Clear();
        fivenames.Clear();
        list3.text = "3 star: ";
        list4.text = "4 star: ";
        list5.text = "5 star: ";
    }
}
