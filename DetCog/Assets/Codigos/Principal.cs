using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class Principal : MonoBehaviour
{
    // Vitual Buttons
    public VirtualButtonBehaviour btnAzul;
    public VirtualButtonBehaviour btnRojo;
    public bool btnAzulPres;
    public bool btnRojoPres;

    // Modelos
    public GameObject modelo1;
    public GameObject modelo2;
    public GameObject modelo3;
    public GameObject modelo4;
    public GameObject modelo5;
    public GameObject modelo6;
    public GameObject modelo7;
    public GameObject modelo8;
    public GameObject modelo9;
    public GameObject modelo10;

    // Juego
    public int puntacion;
    bool [] conteo = new bool[10];
    public Text puntajeTXT;
    public Text acierto;
    public GameObject btnReinicio;

    // Start is called before the first frame update
    void Start()
    {

        btnAzul.RegisterOnButtonPressed(BotonAzulPresionado);
        btnAzul.RegisterOnButtonReleased(BotonAzulSuelto);

        btnRojo.RegisterOnButtonPressed(BotonRojoPresionado);
        btnRojo.RegisterOnButtonReleased(BotonRojoSuelto);

        btnAzulPres = false;
        btnRojoPres = false;
        puntacion = 0;
    }

    // Update is called once per frame
    void Update()
    {
        juego();
        juegoTermino();
    }

    public void BotonAzulPresionado(VirtualButtonBehaviour vb)
    {
        btnAzulPres = true;
        //mensaje.text = "Color Azul";
    }

    public void BotonAzulSuelto(VirtualButtonBehaviour vb)
    {
        btnAzulPres = false;
        //mensaje.text = "";
    }

    public void BotonRojoPresionado(VirtualButtonBehaviour vb)
    {
        btnRojoPres = true;
        //mensaje.text = "Color Rojo";
    }

    public void BotonRojoSuelto(VirtualButtonBehaviour vb)
    {
        btnRojoPres = false;
        //mensaje.text = "";
    }
    public void juego()
    {
        // ----------- Marcador 1 -----------
        if (modelo1.activeSelf && !conteo[0] && btnRojoPres)
        {
            puntacion++;
            puntajeTXT.text = puntacion.ToString();
            conteo[0] = true;
            acierto.text = "Correcto";
        }

        if (modelo1.activeSelf && !conteo[0] && btnAzulPres)
        {
            conteo[0] = true;
            acierto.text = "Incorrecto";
        }

        // ----------- Marcador 2 -----------
        if (modelo2.activeSelf && !conteo[1] && btnAzulPres)
        {
            puntacion++;
            puntajeTXT.text = puntacion.ToString();
            conteo[1] = true;
            acierto.text = "Correcto";
        }

        if (modelo2.activeSelf && !conteo[1] && btnRojoPres)
        {
            conteo[1] = true;
            acierto.text = "Incorrecto";
        }

        // ----------- Marcador 3 -----------
        if (modelo3.activeSelf && !conteo[2] && btnRojoPres)
        {
            puntacion++;
            puntajeTXT.text = puntacion.ToString();
            conteo[2] = true;
            acierto.text = "Correcto";
        }

        if (modelo3.activeSelf && !conteo[2] && btnAzulPres)
        {
            conteo[2] = true;
            acierto.text = "Incorrecto";
        }

        // ----------- Marcador 4 -----------
        if (modelo4.activeSelf && !conteo[3] && btnAzulPres)
        {
            puntacion++;
            puntajeTXT.text = puntacion.ToString();
            conteo[3] = true;
            acierto.text = "Correcto";
        }

        if (modelo4.activeSelf && !conteo[3] && btnRojoPres)
        {
            conteo[3] = true;
            acierto.text = "Incorrecto";
        }

        // ----------- Marcador 5 -----------
        if (modelo5.activeSelf && !conteo[4] && btnRojoPres)
        {
            puntacion++;
            puntajeTXT.text = puntacion.ToString();
            conteo[4] = true;
            acierto.text = "Correcto";
        }

        if (modelo5.activeSelf && !conteo[4] && btnAzulPres)
        {
            conteo[4] = true;
            acierto.text = "Incorrecto";
        }

        // ----------- Marcador 6 -----------
        if (modelo6.activeSelf && !conteo[5] && btnAzulPres)
        {
            puntacion++;
            puntajeTXT.text = puntacion.ToString();
            conteo[5] = true;
            acierto.text = "Correcto";
        }

        if (modelo6.activeSelf && !conteo[5] && btnRojoPres)
        {
            conteo[5] = true;
            acierto.text = "Incorrecto";
        }

        // ----------- Marcador 7 -----------
        if (modelo7.activeSelf && !conteo[6] && btnRojoPres)
        {
            puntacion++;
            puntajeTXT.text = puntacion.ToString();
            conteo[6] = true;
            acierto.text = "Correcto";
        }

        if (modelo7.activeSelf && !conteo[6] && btnAzulPres)
        {
            conteo[6] = true;
            acierto.text = "Incorrecto";
        }

        // ----------- Marcador 8 -----------
        if (modelo8.activeSelf && !conteo[7] && btnAzulPres)
        {
            puntacion++;
            puntajeTXT.text = puntacion.ToString();
            conteo[7] = true;
            acierto.text = "Correcto";
        }

        if (modelo8.activeSelf && !conteo[7] && btnRojoPres)
        {
            conteo[7] = true;
            acierto.text = "Incorrecto";
        }

        // ----------- Marcador 9 -----------
        if (modelo9.activeSelf && !conteo[8] && btnRojoPres)
        {
            puntacion++;
            puntajeTXT.text = puntacion.ToString();
            conteo[8] = true;
            acierto.text = "Correcto";
        }

        if (modelo9.activeSelf && !conteo[8] && btnAzulPres)
        {
            conteo[8] = true;
            acierto.text = "Incorrecto";
        }

        // ----------- Marcador 10 -----------
        if (modelo10.activeSelf && !conteo[9] && btnAzulPres)
        {
            puntacion++;
            puntajeTXT.text = puntacion.ToString();
            conteo[9] = true;
            acierto.text = "Correcto";
        }

        if (modelo10.activeSelf && !conteo[9] && btnRojoPres)
        {
            conteo[9] = true;
            acierto.text = "Incorrecto";
        }

    }

    public void juegoTermino()
    {
        int listos = 0;
        for (int i = 0; i < conteo.Length; i++)
        {
            if (conteo[i])
                listos++;
        }

        if (listos == 10)
            btnReinicio.SetActive(true);
    }

    public void juegoReinicio()
    {
        puntacion = 0;
        puntajeTXT.text = puntacion.ToString();
        btnAzulPres = false;
        btnRojoPres = false;
        acierto.text = "";

        for (int i = 0; i < conteo.Length; i++)
            conteo[i] = false;

        modelo1.SetActive(false);
        modelo2.SetActive(false);
        modelo3.SetActive(false);
        modelo4.SetActive(false);
        modelo5.SetActive(false);
        modelo6.SetActive(false);
        modelo7.SetActive(false);
        modelo8.SetActive(false);
        modelo9.SetActive(false);
        modelo10.SetActive(false);
    }
}
