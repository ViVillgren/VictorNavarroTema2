using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] private string sound = "¡Brum, brum!";
    [SerializeField] private string name;
    [SerializeField] private int numberWheels = 4;
    public bool hasSiren;
    [SerializeField] private bool isOn;
    [SerializeField] private float gasoline;
    //Variable sound, name y numberWheels se guarda en el vehiculo

    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(message: $" {name} tiene {numberWheels} ruedas y hace {sound}");
        if (hasSiren)
        {
            Debug.Log(message: $" {name} tiene sirena");
        }
        else
        {
            Debug.Log(message: $" {name} no tiene sirena");
        }

        //hemos hecho para que el codigo confirme si el vehiculo tiene sirena y cuantas reudas tiene y el sonido que hace cada vehiculo

        //El codigo guarda la nueva variable hasSiren y comprueba el operador de decision
        /*
        if (isOn)
        {
            Debug.Log(message: $"{sound}");
        }
        else if (hasSiren)
        {
            Debug.Log(message: $" {name} hara {sound} cuando se ponga en marcha");
        }
        else
        {
            Debug.Log(message: $" {name} no esta en marcha");
        }
        */
        
     
        if (isOn == true)
        {

            if (gasoline <10)
            {
                Debug.Log(message: $" a {name} le queda poca gasolina");

            }
            if (hasSiren)
            {
                Debug.Log(message: $" {sound}");
            }
            else
            { 
                Debug.Log(message: $" {name} no tiene sirena"); 
            }
        }
        else
        {
            Debug.Log(message: $" {name} no esta en marcha");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position += Vector3.right;
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position += Vector3.left;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.position += Vector3.forward;
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.position += Vector3.back;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.position += Vector3.up;
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                transform.position += Vector3.down;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.rotation *= Quaternion.Euler(x: 0, y: 10, z: 0);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.rotation *= Quaternion.Euler(x: 0, y: -10, z: 0);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.rotation *= Quaternion.Euler(x: 10, y: 0, z: 0);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.rotation *= Quaternion.Euler(x: -10, y: 0, z: 0);
            }
        }

        
    }
}
