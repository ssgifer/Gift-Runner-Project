using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("City");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
