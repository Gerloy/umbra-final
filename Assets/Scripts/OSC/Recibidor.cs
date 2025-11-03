using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recibidor : MonoBehaviour
{
    [SerializeField] OSC osc;
    [SerializeField] cant cants;
    // Start is called before the first frame update
    void Start()
    {
        osc.SetAllMessageHandler(Recibe);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Recibe(OscMessage mensaje)
    {
        //Debug.Log("Recibe un mensaje de direccion: " + mensaje.address);
        //if (mensaje.address == "/artistas") { cants.setArtistas(mensaje.GetInt(0),mensaje.GetInt(1)); }
        //if (mensaje.address == "/deportistas") { cants.setDeportistas(mensaje.GetInt(0),mensaje.GetInt(1)); }
        //if (mensaje.address == "/cocineros") { cants.setCocineros(mensaje.GetInt(0),mensaje.GetInt(1)); }

        if (mensaje.address == "/artistas") { cants.setArtistas(mensaje.GetInt(0));}
        if (mensaje.address == "/deportistas") { cants.setDeportistas(mensaje.GetInt(0));}
        if (mensaje.address == "/cocineros") { cants.setCocineros(mensaje.GetInt(0)); Debug.Log("Llego mensaje de cocineros");}
    }
}
