using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Seleccionar : MonoBehaviour
{
    public GameObject VentanaAmarillo;
    public GameObject VentanaNegro;
    public GameObject VentanaBlanco;
    public GameObject VentanaVerde;

    Animation AVentanaAmarillo;
    Animation AVentanaNegro;
    Animation AVentanaBlanco;
    Animation AVentanaVerde;

    bool VisibleVAmarillo = false;
    bool VisibleVNegro = false;
    bool VisibleVBlanco = false;
    bool VisibleVVerde = false;

    void Start()
    {
        AVentanaAmarillo = VentanaAmarillo.GetComponent<Animation>();
        AVentanaBlanco = VentanaBlanco.GetComponent<Animation>();
        AVentanaNegro = VentanaNegro.GetComponent<Animation>();
        AVentanaVerde = VentanaVerde.GetComponent<Animation>();
    }

    public void VentanaAmaPulsada()
    {
        if (VisibleVAmarillo == false)
        {
            AVentanaAmarillo["Lambo amarillo"].speed = 1;
            AVentanaAmarillo.Play();
            VisibleVAmarillo = true;
        }
    }
    public void VentanaBlaPulsada()
    {
        if (VisibleVBlanco == false)
        {
            AVentanaBlanco["Lambo blanco"].speed = 1;
            AVentanaBlanco.Play();
            VisibleVBlanco = true;
        }
    }
    public void VentanaNegPulsada()
    {
        if (VisibleVNegro == false)
        {
            AVentanaNegro["Lambo negro"].speed = 1;
            AVentanaNegro.Play();
            VisibleVNegro = true;
        }
    }
     public void VentanaVerPulsada()
    {
        if (VisibleVVerde == false)
        {
            AVentanaVerde["Lambo verde"].speed = 1;
            AVentanaVerde.Play();
            VisibleVVerde = true;
        }
    }

    public void VentanaNoPulsada()
    {
        string NombreBoton = EventSystem.current.currentSelectedGameObject.name;

        if (NombreBoton != "Lambo amarillo" & VisibleVAmarillo == true)
        {
            AVentanaAmarillo["Lambo amarillo"].speed = -1;
            AVentanaAmarillo["Lambo amarillo"].time = AVentanaAmarillo["Lambo amarillo"].length;
            AVentanaAmarillo.Play();
            VisibleVAmarillo = false;
        }
        if (NombreBoton != "Lambo negro" & VisibleVNegro == true)
        {
            AVentanaNegro["Lambo negro"].speed = -1;
            AVentanaNegro["Lambo negro"].time = AVentanaNegro["Lambo negro"].length;
            AVentanaNegro.Play();
            VisibleVNegro = false;
        }
        if (NombreBoton != "Lambo blanco" & VisibleVBlanco == true)
        {
            AVentanaBlanco["Lambo blanco"].speed = -1;
            AVentanaBlanco["Lambo blacno"].time = AVentanaBlanco["Lambo blanco"].length;
            AVentanaBlanco.Play();
            VisibleVBlanco = false;
        }
        if (NombreBoton != "Lambo verde" & VisibleVVerde == true)
        {
            AVentanaVerde["Lambo verde"].speed = -1;
            AVentanaVerde["Lambo verde"].time = AVentanaVerde["Lambo verde"].length;
            AVentanaVerde.Play();
            VisibleVVerde = false;
        }
    }
}
