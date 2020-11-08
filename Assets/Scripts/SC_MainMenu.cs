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