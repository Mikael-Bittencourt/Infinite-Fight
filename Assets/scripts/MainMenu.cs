using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Game()
    {
        // loading the game
       SceneManager.LoadScene("Game");
    }

     public void QuitGame()
    {
        //quit name
       Debug.Log("Quitting game...");
       Application.Quit();
    }

}
