using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopFor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //VARIAVEL, CONDICAO, INCREMENTO/DECREMENTO
        for(int x = 1; x <= 10; x++ ){
                print("Meu inteiro vale "+ x +".");
        }
        print ("Acabou o Loop!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
