using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuMusic : MonoBehaviour
{

    public AudioSource audioSourceMenu;
    public AudioClip songName1;
    public AudioClip songName2;
    public AudioClip songName3;


    private AudioClip[] musicList = new AudioClip[18];

    // Start is called before the first frame update
    void Start()
    {

        int width = 1280;
        int height = 720;

        bool isFullScreen = false;
        int desiredFPS = 60;
        Screen.SetResolution(width, height, isFullScreen, desiredFPS);

        musicList[0] = songName1;
        musicList[1] = songName2;
        musicList[2] = songName3;


        audioSourceMenu.clip = musicList[0];
        audioSourceMenu.loop = true;
        audioSourceMenu.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
