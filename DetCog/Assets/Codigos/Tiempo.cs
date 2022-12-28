using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Tiempo : MonoBehaviour
{
    public float tiempoInicio;
    public Text textoTiempo;
    public Text textoBoton;

    bool activoTiempo = false;

    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        textoTiempo.text = tiempoInicio.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        if(activoTiempo)
        {
            tiempoInicio += Time.deltaTime;
            textoTiempo.text = tiempoInicio.ToString("F2");
        }
    }

    public void botonTiempo()
    {
        activoTiempo = !activoTiempo;
        textoBoton.text = activoTiempo ? "Pausar" : "Iniciar";
    }
}
