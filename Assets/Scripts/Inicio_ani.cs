using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inicio_ani : MonoBehaviour
{
    [SerializeField] Texture2D img;
    [SerializeField] float cool;
    private float t;

    // Start is called before the first frame update
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t >= cool) { gameObject.GetComponent<RawImage>().texture = img; }
    }
}
