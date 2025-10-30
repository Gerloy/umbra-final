using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

[CreateAssetMenu(fileName = "Equipo", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class Equipo : ScriptableObject
{
    public enum equipos {ARTISTAS, COCINEROS, DEPORTISTAS};

    private int valor;

    public void setValor(int _valor) { valor = _valor; }
    public int getValor() { return valor; }
}
