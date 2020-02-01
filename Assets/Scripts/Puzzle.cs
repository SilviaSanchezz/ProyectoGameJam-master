using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public List<Sprite> fichaImg = new List<Sprite>();  //lista donde almacenará los sprites cortados de cada ficha
    public GameObject fichaPrefab; //ficha basica de la cual se crearan el resto
    public GameObject bordePrefab; //borde basico del cual se crearan el resto
    public Sprite fichaEscondidaImg; //Para guarda imagen de la ficha que no se va a ver
    public GameObject textoGanador; //Texto cuando se complete el puzzle

    private GameObject fichaEscondida; //objeto de la ficha escondida
    private int numCostado; //el numero de fichas por lado
    private GameObject padreFichas; //para organizar la escena
    private GameObject padreBordes; //para organizar la escena
    private List<Vector3> posicionesIniciales = new List<Vector3>(); //donde se almacenaran las posiciones iniciales, para comparar luego si se ha hecho bien
    private GameObject[] arrayFichas; //donde almacenaremos nuestras fichas




    private void Awake()
    {
        //buscamos los objetos que nos almacenaran las fichas y los bordes
        padreFichas = GameObject.Find("Fichas");
        padreBordes = GameObject.Find("Bordes");
    }


    void Start()
    {
        if (Mathf.Sqrt (fichaImg.Count) == Mathf.Round (Mathf.Sqrt(fichaImg.Count))) //Comprueba si el numero de fichas es cuadrado
        {

        } else {
            print("Imposible crear fichas");
        }
    }

    void CrearFichas()
    {
        int contador = 0;
        numCostado = (int)Mathf.Sqrt(fichaImg.Count);

        //Doble bucle para colocar todas las fichas en su sitio

        for (int alto = numCostado + 2; alto > 0; alto--){
            for (int ancho = 0; ancho < numCostado + 2; ancho++){
                
                Vector3 posicion = new Vector3(ancho - (numCostado / 2), alto - (numCostado / 2), 0); //posicion de cada ficha

                //comprobar si son posiciones de borde o de fichas
                if (alto == 1 || alto == numCostado + 2 || ancho == 0 || ancho == numCostado +1) {  //creando el borde
                    
                    GameObject borde = Instantiate(bordePrefab, posicion, Quaternion.identity);     //instanciamos el borde
                    borde.transform.parent = padreBordes.transform;                                 //lo ponemos como hijo de padreBordes

                } else {                                                                            //creando las fichas del puzzle

                    GameObject ficha = Instantiate(fichaPrefab, posicion, Quaternion.identity);     //instanciamos la ficha
                    ficha.GetComponent<SpriteRenderer>().sprite = fichaImg[contador];               //asignamos el sprite de cada ficha
                    ficha.transform.parent = padreFichas.transform;                                 //lo ponemos como hijo de padreFichas
                    ficha.name = fichaImg[contador].name;                                           //dejamos el mismo nombre que el sprite
                    if (ficha.name == fichaEscondidaImg.name)                                       //Si es la ficha que tenemos que esconder
                        fichaEscondida = ficha;                                                     //la asignamos
                    contador++;

                }
            }
        }

        fichaEscondida.gameObject.SetActive(false);                                                 //escondemos la ficha escondida
                                                                                                    //a continuacion almacenamos las posiciones iniciales
        arrayFichas = GameObject.FindGameObjectsWithTag("Ficha");                                   //recuperamos todas las fichas con el tag ficha
        for (int i = 0; i < arrayFichas.Length; i++){
            posicionesIniciales.Add(arrayFichas[i].transform.position);                             //Asignamos las posiciones iniciales de las fichas
        }




        //barajar las fichas
    }

    
}
