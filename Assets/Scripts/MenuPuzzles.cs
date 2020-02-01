using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuPuzzles : MonoBehaviour
{
    public Transform button1;
    public Transform button2;
    public Transform button3;
    public Transform button4;
    public Transform button5;
    public Transform button6;
    public Transform button7;
   
    void Start()
    {
        button2.GetComponent<Button>().interactable = false;
        button3.GetComponent<Button>().interactable = false;
        button4.GetComponent<Button>().interactable = false;
        button5.GetComponent<Button>().interactable = false;
        button6.GetComponent<Button>().interactable = false;
        button7.GetComponent<Button>().interactable = false;
        button7.gameObject.SetActive(false);                    //button7 empieza desactivado
    }

    public void LoadScene1()
    {
        SceneManager.LoadScene("EscenaPrimerPuzzle");
        button1.GetComponent<Button>().interactable = false; //Desactivar button actual
        button2.GetComponent<Button>().interactable = true;  //Activar siguiente button
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("EscenaSegundoPuzzle");
        button2.GetComponent<Button>().interactable = false;
        button3.GetComponent<Button>().interactable = true;
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("EscenaTercerPuzzle");
        button3.GetComponent<Button>().interactable = false;
        button4.GetComponent<Button>().interactable = true;
    }

    public void LoadScene4()
    {
        SceneManager.LoadScene("EscenaCuartoPuzzle");
        button4.GetComponent<Button>().interactable = false;
        button5.GetComponent<Button>().interactable = true;
    }

    public void LoadScene5()
    {
        SceneManager.LoadScene("EscenaQuintoPuzzle");
        button5.GetComponent<Button>().interactable = false;
        button6.GetComponent<Button>().interactable = true;
    }

    public void LoadScene6()
    {
        SceneManager.LoadScene("EscenaSextoPuzzle");
        button6.GetComponent<Button>().interactable = false;
        button7.gameObject.SetActive(true);                     //Activar button7
        button7.GetComponent<Button>().interactable = true;
    }

    public void LoadScene7()
    {
        SceneManager.LoadScene("EscenaSeptimaPuzzle");
        
    }

    public void VolverAtras()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

}
