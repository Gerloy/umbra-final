using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerJuego : MonoBehaviour
{
    const int MAX = 1;
    [SerializeField] OSC osc;
    [SerializeField] Equipo equipo;
    [SerializeField] string to_scene;
    [SerializeField] float tiempo_total;
    [SerializeField] GameObject texto_cronometro;
    private float t;
    private int cant_artistas = 0;
    private int cant_deportistas = 0;
    private int cant_cocineros = 0;
    // Start is called before the first frame update
    void Start()
    {
        t = tiempo_total;
        osc.SetAllMessageHandler(Recibe);
    }

    // Update is called once per frame
    void Update()
    {
        if (t <= 0)
        {
            
            if ((cant_artistas > cant_deportistas) && (cant_artistas > cant_cocineros)) { equipo.setValor(Equipo.equipos.ARTISTAS); SceneManager.LoadScene(to_scene); }
            if ((cant_deportistas > cant_artistas) && (cant_deportistas > cant_cocineros)) { equipo.setValor(Equipo.equipos.DEPORTISTAS); SceneManager.LoadScene(to_scene); }
            if ((cant_cocineros > cant_deportistas) && (cant_cocineros > cant_artistas)) { equipo.setValor(Equipo.equipos.COCINEROS); SceneManager.LoadScene(to_scene); }
            //Si hay dos iguales despues vemos que pasa. Por ahora esto sirve
            else
            {
                equipo.setValor(Equipo.equipos.COCINEROS); SceneManager.LoadScene(to_scene);
            }
        }

        //Basta para mi basta para todos
        if (cant_artistas == MAX) { equipo.setValor(Equipo.equipos.ARTISTAS); SceneManager.LoadScene(to_scene); }
        if (cant_deportistas == MAX) { equipo.setValor(Equipo.equipos.DEPORTISTAS); SceneManager.LoadScene(to_scene); }
        if (cant_cocineros == MAX) { equipo.setValor(Equipo.equipos.COCINEROS); SceneManager.LoadScene(to_scene); }

        texto_cronometro.GetComponent<TextMeshProUGUI>().text = Math.Floor(t).ToString();

        t -= Time.deltaTime;
    }

    void Recibe(OscMessage mensaje)
    {
        if (mensaje.address == "/artistas") { cant_artistas = mensaje.GetInt(0); }
        if (mensaje.address == "/deportistas") { cant_cocineros = mensaje.GetInt(0); }
        if (mensaje.address == "/cocineros") { cant_cocineros = mensaje.GetInt(0); }
    }
}
