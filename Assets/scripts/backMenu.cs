﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backMenu : MonoBehaviour
{
   public void BackMenu()
    {
        // loading the game
       SceneManager.LoadScene("Menu");
    }
}
