using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
    [SerializeField] float time_total;
    private float t = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        //Tiene que tener si o si un textmesh
        gameObject.GetComponent<TextMesh>().text = Math.Floor(t).ToString();
    }
}
