using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{

    public AudioSource audioJuego;
    // Start is called before the first frame update
    
    public void sonido(bool flag)
    {
        Debug.Log("SOUND");
        if (flag)
        {
            audioJuego.Play();
        }
        else
        {
            audioJuego.Pause();
        }
        
    }
}
