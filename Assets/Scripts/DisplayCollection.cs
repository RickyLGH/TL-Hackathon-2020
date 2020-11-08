using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCollection : MonoBehaviour
{
    public Image images;

    List<Sprite> spritelist = new List<Sprite>();

    public void Start()
    {
        Display();
    }

    public void Display()
    {
        foreach(GameObject player in GameManager.Instance.collection)
        {
            PlayerData data = player.GetComponent<PlayerData>();
            spritelist.Add(data.sprite);
        }

        foreach(Sprite sprite in spritelist)
        {
            Instantiate(sprite);
        }
    }
}
