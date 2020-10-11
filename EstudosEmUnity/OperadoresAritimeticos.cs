using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperadoresAritmeticos : MonoBehaviour
{
    public int numero01 = 10, numero02 =20, numero03 = 15;
    // Start is called before the first frame update
    void Start()
    {
        //Teste de Soma
        float resultadoSoma;
        resultadoSoma = numero01 + numero02;
        print ("O resultado da soma de " + numero01.ToString() + " e " + numero02.ToString() +" é " + resultadoSoma.ToString() + ".");

        //Teste de Subtração
        float resultadoSubtracao;
        resultadoSubtracao = numero02 - numero01;
        print ("O resultado da subtracao de " + numero02.ToString() + " e " + numero03.ToString() +" é " + resultadoSubtracao.ToString() + ".");

        //Teste de Multiplicacao
        float resultadoMultiplicacao;
        resultadoMultiplicacao = numero03 * numero02;
        print ("O resultado da multiplicacao de " + numero03.ToString() + " e " + numero02.ToString() + " é " + resultadoMultiplicacao.ToString() + ".");

        //Teste de Divisao
        float resultadoDivisao;
        resultadoDivisao = numero03 / numero02;
        print ("O resultado da divisao de " + numero03.ToString() + " e " + numero02.ToString() + " é " + resultadoDivisao.ToString() + ".");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
