using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MainMenu: MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject GachaMenu;
	public GameObject CollectionMenu;

    private void PlayNowButton()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameSim");
    }

    public void GachaButton()
    {
        // Show Credits Menu
		Debug.Log("Gacha Menu Loaded");
        MainMenu.SetActive(false);
        GachaMenu.SetActive(true);
		CollectionMenu.SetActive(false);
    }

    public void MainMenuButton()
    {
        // Show Main Menu
		Debug.Log("Start Menu Loaded");
        MainMenu.SetActive(true);
        GachaMenu.SetActive(false);
		CollectionMenu.SetActive(false);
        GameManager.Instance.player.SetActive(false);
        GameManager.Instance.dg.SetActive(false);
        GameManager.Instance.fq.SetActive(false);
        GameManager.Instance.imt.SetActive(false);
        GameManager.Instance.eg.SetActive(false);
        GameManager.Instance.gg.SetActive(false);
        GameManager.Instance.hundredthieves.SetActive(false);
        GameManager.Instance.cnine.SetActive(false);
        GameManager.Instance.clg.SetActive(false);
        GameManager.Instance.tsm.SetActive(false);
        GameManager.Instance.tl.SetActive(false);
        GameManager.Instance.starthree.SetActive(false);
        GameManager.Instance.starfive.SetActive(false);
        GameManager.Instance.starfour.SetActive(false);
        GameManager.Instance.rolesupp.SetActive(false);
        GameManager.Instance.rolebot.SetActive(false);
        GameManager.Instance.rolemid.SetActive(false);
        GameManager.Instance.rolejgl.SetActive(false);
        GameManager.Instance.roletop.SetActive(false);
    }
	
	public void CollectionButton()
    {
        // Show Main Menu
		Debug.Log("Collection Menu Loaded");
        MainMenu.SetActive(false);
        GachaMenu.SetActive(false);
		CollectionMenu.SetActive(true);
    }

    public void QuitButton()
    {
        // Quit Game
        Application.Quit();
    }
}