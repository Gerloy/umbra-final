using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cantidades", menuName = "ScriptableObjects/Cantidades", order = 2)]
public class cant : ScriptableObject
{
    //public enum equipos {ARTISTAS, COCINEROS, DEPORTISTAS};

    [SerializeField] private int artistas;
    [SerializeField] private int deportistas;
    [SerializeField] private int cocineros;

    public void setArtistas(int a) { artistas = a; }
    public int getArtistas() { return artistas; }

    public void setDeportistas(int a) { deportistas = a; }
    public int getDeportistas() { return deportistas; }

    public void setCocineros(int a) { cocineros = a; }
    public int getCocineros() { return cocineros; }
}
