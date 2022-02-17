using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Side : MonoBehaviour
{
    public void Back() => SceneManager.LoadScene("Home");
    public void City() => SceneManager.LoadScene("City");
    public void Beach() => SceneManager.LoadScene("Beach");
    public void Desert() => SceneManager.LoadScene("Desert");
}
