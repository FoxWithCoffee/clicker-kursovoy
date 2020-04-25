using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour
{
    public static bool isloading = false;
    public void NewGame()
    {
        //reset line
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(1);
    }
    public void LoadGame()
    {
        isloading = true;
        SceneManager.LoadScene(1);
    }
}
