using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inicio_Nuevo : MonoBehaviour
{
    const int MAX = 1;
    //[SerializeField] Equipo equipo;
    [SerializeField] cant cants;
    [SerializeField] string to_scene;
    [SerializeField] string current;
    private int cant_artistas = 0;
    private int cant_deportistas = 0;
    private int cant_cocineros = 0;
    private bool cargo_osc = false;
    private bool cambio_scn = false;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i < SceneManager.sceneCount; i++){
            Scene actual = SceneManager.GetSceneAt(i);
            if (actual.name == "OSC"){
                cargo_osc = true;
            }
        }
        if (!cargo_osc){SceneManager.LoadSceneAsync("OSC",LoadSceneMode.Additive);}
    }

    void Update()
    {
        cant_artistas = cants.getArtistas();
        cant_cocineros = cants.getCocineros();
        cant_deportistas = cants.getDeportistas();
        //Debug.Log("Cocineros" + cant_cocineros);
        //Debug.Log("Artistas" + cant_artistas);
        //Debug.Log("Deportistas" + cant_deportistas);
        /*for (int i = 0; i < 5; i++){
            cant_artistas += cants.getArtistas(i);
            cant_deportistas += cants.getDeportistas(i);
            cant_cocineros += cants.getCocineros(i);
        }*/
        //Debug.Log("Cant cocineros" + cant_cocineros);

        //Basta para mi basta para todos
        if (cant_artistas >= MAX) {
            //equipo.setValor(Equipo.equipos.ARTISTAS);
            if (!cambio_scn){
                SceneManager.LoadSceneAsync(to_scene,LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync(current);
                cambio_scn = true;
            }
        }
        if (cant_deportistas >= MAX) {
            //equipo.setValor(Equipo.equipos.DEPORTISTAS);
            if (!cambio_scn){
                SceneManager.LoadSceneAsync(to_scene,LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync(current);
                cambio_scn = true;
            }
        }
        if (cant_cocineros >= MAX) {
            //equipo.setValor(Equipo.equipos.COCINEROS);
            if (!cambio_scn){
                SceneManager.LoadSceneAsync(to_scene,LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync(current);
                cambio_scn = true;
            }
        }
    }
}
