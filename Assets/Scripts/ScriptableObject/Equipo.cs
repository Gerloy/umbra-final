using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

[CreateAssetMenu(fileName = "Equipo", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class Equipo : ScriptableObject
{
    public enum equipos {ARTISTAS, COCINEROS, DEPORTISTAS};

    [SerializeField] private equipos valor;

    public void setValor(equipos _valor) { valor = _valor; }
    public equipos getValor() { return valor; }
}
