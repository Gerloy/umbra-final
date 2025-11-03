using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Victoria : MonoBehaviour
{
    [SerializeField] Equipo equipo;
    [SerializeField] Texture2D[] imgs;
    [SerializeField] float cool;
    [SerializeField] string to_scene;
    [SerializeField] string current;
    private bool cambio_scn;
    private float t = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log((int)equipo.getValor());
        if (t >= cool){
            if(!cambio_scn){
                SceneManager.LoadSceneAsync(to_scene,LoadSceneMode.Additive);
                SceneManager.UnloadScene(current);
                cambio_scn = true;
            }
        }
        gameObject.GetComponent<RawImage>().texture = imgs[(int)equipo.getValor()];
        t += Time.deltaTime;
    }
}
