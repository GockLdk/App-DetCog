using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class Principal : MonoBehaviour
{
    public VirtualButtonBehaviour btnAzul;
    public VirtualButtonBehaviour btnRojo;

    public Text mensaje;
    // Start is called before the first frame update
    void Start()
    {
        btnAzul.RegisterOnButtonPressed(BotonAzulPresionado);
        btnAzul.RegisterOnButtonReleased(BotonAzulSuelto);

        btnRojo.RegisterOnButtonPressed(BotonRojoPresionado);
        btnRojo.RegisterOnButtonReleased(BotonRojoSuelto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BotonAzulPresionado(VirtualButtonBehaviour vb)
    {
        mensaje.text = "Color Azul";
    }

    public void BotonAzulSuelto(VirtualButtonBehaviour vb)
    {
        mensaje.text = "";
    }

    public void BotonRojoPresionado(VirtualButtonBehaviour vb)
    {
        mensaje.text = "Color Rojo";
    }

    public void BotonRojoSuelto(VirtualButtonBehaviour vb)
    {
        mensaje.text = "";
    }
}
