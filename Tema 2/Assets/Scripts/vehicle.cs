using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicle : MonoBehaviour
{
    //La variable sound guarda el sondido que hace el vehiculo
    [SerializeField]
    private string Sound = "¡Brum, brum!";
    //La variable name guarda el nombre del vehiculo
    [SerializeField] private string name;
    //La variable numberWheels guarda el numero de ruedas
    [SerializeField] private int numberWheels = 4;
    //Variavle booleana if
    [SerializeField] private bool hasSiren;
    [SerializeField] private bool isOn;
    [SerializeField] private int x = 4;
    [SerializeField] private int y = 2;
    [SerializeField] private int z = 2;
    [SerializeField] private float gasolina;


    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log(Sound);
        Debug.Log(message:$"Hola {Sound}");
        

        Debug.Log(message:$"{name} tiene {numberWheels} ruedas y hace {Sound}");
        // Debug.Log(message:string.Format("Resta: {0} - {1} = {2}", x, y, x - y));

        if (hasSiren)
        {
            Debug.Log(message:$"{name} tiene sirena");
        }
        else
        {
            Debug.Log(message:$"{name} no tiene sirena"); 
        }
        */

        /*

         if (x != y) //diferencia !=
         {
             Debug.Log(message: "x es igual a y");
         }

         if (z == y) //igual ==
         {
             Debug.Log(message: "z es igual a y");
         }
        */
        /*
        if (isOn == true)
        {
            Debug.Log(message: $"{Sound}");
        }
        else if (hasSiren == true)
        {
            Debug.Log(message: $"{name} hará {Sound} cuando se ponga en marcha");
        }
        else
        {
            Debug.Log(message: $"{name} no está en marcha");
        }
        */

        if (isOn == true)
        {
            if (gasolina < 10)
            {
                Debug.Log(message: $"a {name} le quda poca gasolina");
            }
            
            if (hasSiren == true)
            {
                Debug.Log(message: $"{Sound}");
            }
            else
            {
                Debug.Log(message: $"{name} no tiene sirena.");
            }
        }
        else
        {
            Debug.Log(message: $"{name} no está en marcha");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn == true)
        { 
       
            if  (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.position += Vector3.forward;
            }
        }


    }
}
