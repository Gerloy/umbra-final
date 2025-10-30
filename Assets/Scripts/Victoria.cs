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
    [SerializeField] UnityEngine.SceneManagement.Scene to_scene;
    private float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (t >= cool){ SceneManager.LoadScene(to_scene.name); }
        gameObject.GetComponent<RawImage>().texture = imgs[equipo.getValor()];
        t += Time.deltaTime;
    }
}
