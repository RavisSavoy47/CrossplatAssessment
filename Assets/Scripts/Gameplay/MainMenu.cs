using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //goes to the next scene
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
}
