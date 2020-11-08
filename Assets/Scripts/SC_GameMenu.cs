using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_GameMenu: MonoBehaviour
{
    public GameObject SelectionMenu;
	public GameObject TopMenu;
	public GameObject JgMenu;
	public GameObject MidMenu;
	public GameObject BotMenu;
	public GameObject SuppMenu;

    public void BackButton()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        SceneManager.LoadScene("StartScreen");
    }
	
	public void MainMenuButton()
    {
        // Show Credits Menu
		Debug.Log("Game Menu Loaded");
        SelectionMenu.SetActive(true);
		TopMenu.SetActive(false);
        JgMenu.SetActive(false);
		MidMenu.SetActive(false);
		BotMenu.SetActive(false);
		SuppMenu.SetActive(false);
    }

	public void TopButton()
    {
		Debug.Log("Top Menu Loaded");
		TopMenu.SetActive(true);
		JgMenu.SetActive(false);
		MidMenu.SetActive(false);
		BotMenu.SetActive(false);
		SuppMenu.SetActive(false);
		SelectionMenu.SetActive(false);
    }
	
		public void JgButton()
    {
		Debug.Log("JgMenu Loaded");
        TopMenu.SetActive(false);
        JgMenu.SetActive(true);
		MidMenu.SetActive(false);
		BotMenu.SetActive(false);
		SuppMenu.SetActive(false);
		SelectionMenu.SetActive(false);
    }
	
		public void MidButton()
    {
		Debug.Log("Mid Menu Loaded");
        TopMenu.SetActive(false);
        JgMenu.SetActive(false);
		MidMenu.SetActive(true);
		BotMenu.SetActive(false);
		SuppMenu.SetActive(false);
		SelectionMenu.SetActive(false);
    }
	
		public void BotButton()
    {
		Debug.Log("Bot Menu Loaded");
        TopMenu.SetActive(false);
        JgMenu.SetActive(false);
		MidMenu.SetActive(false);
		BotMenu.SetActive(true);
		SuppMenu.SetActive(false);
		SelectionMenu.SetActive(false);
    }
	
		public void SuppButton()
    {
		Debug.Log("Supp Menu Loaded");
        TopMenu.SetActive(false);
        JgMenu.SetActive(false);
		MidMenu.SetActive(false);
		BotMenu.SetActive(false);
		SuppMenu.SetActive(true);
		SelectionMenu.SetActive(false);
    }
}