using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("InterfazDePuzzle");
    }

    public void CloseApp()
    {
        Application.Quit();
    }

    public void Options()
    {
        SceneManager.LoadScene("MenuOpciones");
    }

}