using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MainMenu: MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject GachaMenu;
	public GameObject CollectionMenu;


    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
    }

    public void PlayNowButton()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameLevel");
    }

    public void GachaButton()
    {
        // Show Credits Menu
        MainMenu.SetActive(false);
        GachaMenu.SetActive(true);
		CollectionMenu.SetActive(false);
    }

    public void MainMenuButton()
    {
        // Show Main Menu
        MainMenu.SetActive(true);
        GachaMenu.SetActive(false);
		CollectionMenu.SetActive(false);
    }
	
	public void CollectionButton()
    {
        // Show Main Menu
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