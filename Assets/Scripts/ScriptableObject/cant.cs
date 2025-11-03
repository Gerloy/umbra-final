using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cantidades", menuName = "ScriptableObjects/Cantidades", order = 2)]
public class cant : ScriptableObject
{
    //public enum equipos {ARTISTAS, COCINEROS, DEPORTISTAS};

    //[SerializeField] private int[] artistas = new int[5];
    //[SerializeField] private int[] deportistas = new int[5];
    //[SerializeField] private int[] cocineros = new int[5];
    [SerializeField] private int artistas;
    [SerializeField] private int deportistas;
    [SerializeField] private int cocineros;

    //public void setArtistas(int i,int v) { if(v == 1){ artistas[i] = 0;}else {artistas[i] = 1;}}
    //public int getArtistas(int i) { return artistas[i]; }
    public void setArtistas(int v) {artistas = v;}
    public int getArtistas(){return artistas;}

    //public void setDeportistas(int i, int v) { if(v == 1){ deportistas[i] = 0;}else {deportistas[i] = 1;}}
    //public int getDeportistas(int i) { return deportistas[i]; }
    public void setDeportistas(int v) {deportistas = v;}
    public int getDeportistas(){return deportistas;}

    //public void setCocineros(int i,int v) { if(v == 1){ cocineros[i] = 0;}else {cocineros[i] = 1;}}
    //public int getCocineros(int i) { return cocineros[i]; }
    public void setCocineros(int v) {cocineros = v;}
    public int getCocineros(){return cocineros;}
}
