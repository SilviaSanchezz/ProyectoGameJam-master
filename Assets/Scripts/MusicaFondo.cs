using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaFondo : MonoBehaviour
{
    private static MusicaFondo instance = null;
    public static MusicaFondo Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        print(gameObject.name);
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
