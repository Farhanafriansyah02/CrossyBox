using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void RestartGame() {
        SceneManager.LoadScene("GamePlay");
    }
    
    public void BackToMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }

    public void SettingMenu()
    {
        SceneManager.LoadScene("SettingMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
