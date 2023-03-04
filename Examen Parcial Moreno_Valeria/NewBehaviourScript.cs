using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JuegoDeSumas : MonoBehaviour
{

    [SerializeField] private TMP_Text SumaEcuación;
    TMP_InputField Revisión;
    int Suma;
    int Resultado;
    int Tiempo = 10 - 0;
    
    

    // Start is called before the first frame update
    void Start()
    {
        Suma = Random.Range(1, 6);
        Suma = 1 + 2;
        SumaEcuación.text = "1+2";



    }

    // Update is called once per frame
    void Update()
    {
        Resultado = Suma;
        if (Resultado != 3)
        {
            Revisión.text = "Te equivocaste, vuelve a intentarlo";

        }
        else

        {
            Revisión.text = "Bien";

            
    }
    }
    void update1()

    {
        

         
    }

}