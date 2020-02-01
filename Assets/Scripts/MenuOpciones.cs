using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOpciones : MonoBehaviour
{
    bool isMute;

    // Start is called before the first frame update
   public void Return()
   {
        SceneManager.LoadScene("MenuPrincipal");
   }
    public void FullScreen()
    {
        Screen.SetResolution(1980, 1080, false);
    }
   
}
