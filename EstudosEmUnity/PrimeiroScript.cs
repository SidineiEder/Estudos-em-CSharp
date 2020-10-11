using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeiroScript : MonoBehaviour
{
    public int vidas;
    public string aviso;
    public bool vivo;
    public float dinheiro = 12.5f;
    int dinheiroInteiro;

    // Isto é um comentário

    /*
    Isto também é um comentário
    */

    // "Start" é chamado após o primeiro frame do Game !
    void Start()
    {
        dinheiroInteiro = (int)dinheiro;
    }

    // "Update" é chamado a cada frame do Game
    void Update()
    {
        
    }
}
