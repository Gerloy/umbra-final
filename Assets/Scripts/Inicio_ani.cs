using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Inicio_ani : MonoBehaviour
{
    [SerializeField] Texture2D img;
    [SerializeField] float cool;
    [SerializeField] string to_scene;
    [SerializeField] string current;
    private float t;
    private bool cargo_osc = false;

    // Start is called before the first frame update
    void Start()
    {
        t = 0;
        for (int i=0; i< SceneManager.sceneCount; i++){
            Scene actual = SceneManager.GetSceneAt(i);
            if (actual.name == "OSC"){
                cargo_osc = true;
            }
        }
        if (!cargo_osc){SceneManager.LoadSceneAsync("OSC",LoadSceneMode.Additive);}
    }

    // Update is called once per frame
    void Update()
    {
        
        t += Time.deltaTime;
        if (t >= cool) { gameObject.GetComponent<RawImage>().texture = img; }

        if (Input.GetKeyDown("a")) {
            SceneManager.LoadSceneAsync(to_scene,LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync(current);
        }
    }
}
