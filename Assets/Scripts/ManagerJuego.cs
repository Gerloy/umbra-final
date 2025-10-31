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
    [SerializeField] cant cants;
    [SerializeField] string to_scene;
    [SerializeField] string current;
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
        //osc.SetAllMessageHandler(Recibe);
    }

    // Update is called once per frame
    void Update()
    {
        cant_artistas = cants.getArtistas();
        cant_deportistas = cants.getDeportistas();
        cant_cocineros = cants.getCocineros();
        if (t <= 0)
        {
            
            if ((cant_artistas > cant_deportistas) && (cant_artistas > cant_cocineros)) {
                equipo.setValor(Equipo.equipos.ARTISTAS);
                SceneManager.LoadSceneAsync(to_scene,LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync(current);
            }
            if ((cant_deportistas > cant_artistas) && (cant_deportistas > cant_cocineros)) {
                equipo.setValor(Equipo.equipos.DEPORTISTAS);
                SceneManager.LoadSceneAsync(to_scene,LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync(current);
            }
            if ((cant_cocineros > cant_deportistas) && (cant_cocineros > cant_artistas)) {
                equipo.setValor(Equipo.equipos.COCINEROS);
                SceneManager.LoadSceneAsync(to_scene,LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync(current);
            }
            //Si hay dos iguales despues vemos que pasa. Por ahora esto sirve
            else
            {
                equipo.setValor(Equipo.equipos.COCINEROS); 
                SceneManager.LoadSceneAsync(to_scene,LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync(current);
            }
        }

        //Basta para mi basta para todos
        if (cant_artistas == MAX) {
            equipo.setValor(Equipo.equipos.ARTISTAS);
            SceneManager.LoadSceneAsync(to_scene,LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync(current);
        }
        if (cant_deportistas == MAX) {
            equipo.setValor(Equipo.equipos.DEPORTISTAS);
            SceneManager.LoadSceneAsync(to_scene,LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync(current);
        }
        if (cant_cocineros == MAX) {
		cant_cocineros = 2323232;
		t = 9999;
            equipo.setValor(Equipo.equipos.COCINEROS);
            SceneManager.LoadSceneAsync(to_scene,LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync(current);
        }

        texto_cronometro.GetComponent<TextMeshProUGUI>().text = Math.Floor(t).ToString();

        t -= Time.deltaTime;
    }

    
}
