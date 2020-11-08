using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCollection : MonoBehaviour
{
    public Image images;
    public Text list3;
    public Text list4;
    public Text list5;
    List<Sprite> spritelist = new List<Sprite>();

    List<string> threenames = new List<string>();
    List<string> fournames = new List<string>();
    List<string> fivenames = new List<string>();

    public void Start()
    {
        Display();
    }

    public void Display()
    {
        foreach(GameObject p in GameManager.Instance.collection)
        {
            var stats = p.GetComponent<Player>();
            
            if(stats.stats.rarity == 3)
            {
                threenames.Add(stats.stats.name);
            }
            if (stats.stats.rarity == 4)
            {
                fournames.Add(stats.stats.name);
            }
            if (stats.stats.rarity == 5)
            {
                fivenames.Add(stats.stats.name);
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
}
