using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tuto_ani : MonoBehaviour
{
    [SerializeField] Texture2D[] imgs;
    [SerializeField] float cool;
    [SerializeField] Scene to_scene;

    private float t = 0;
    private int id = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<RawImage>().texture = imgs[id];
        if (t >= cool)
        {
            if (id < imgs.Length)
            {
                id++;
                t = 0;
            }
            else
            {
                SceneManager.LoadScene(to_scene.name);
            }
        }
        t += Time.deltaTime;
    }
}
