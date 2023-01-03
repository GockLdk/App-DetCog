using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Tiempo : MonoBehaviour
{
    public float tiempoInicio;
    public bool activoTiempo;
    public Text textoTiempo;
    public Text textoBoton;
    public GameObject btnReinicio;

    public GameObject puntaje;
    public string puntos;

    public Text mensaje;   

    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        activoTiempo = false;
        textoTiempo.text = tiempoInicio.ToString("F2");
        btnReinicio.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(activoTiempo)
        {
            tiempoInicio += Time.deltaTime;
            textoTiempo.text = tiempoInicio.ToString("F2");
        }

        
        if (btnReinicio.activeSelf)
        {
            activoTiempo = false;
            mensaje.text = "Juego\nTerminado";
        }
    }

    public void botonInicio()
    {
        activoTiempo = true;
        /*activoTiempo = !activoTiempo;
        textoBoton.text = activoTiempo ? "Pausar" : "Iniciar";*/
    }

    public void botonReinicio()
    {
        tiempoInicio = 0.0f;
        activoTiempo = true;
        mensaje.text = "";
    }
}
