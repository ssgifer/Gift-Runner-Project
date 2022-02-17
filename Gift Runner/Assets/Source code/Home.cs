using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public void NextScenes() => SceneManager.LoadScene("Side");
    public void Exit() => SceneManager.LoadScene("Title");
}
