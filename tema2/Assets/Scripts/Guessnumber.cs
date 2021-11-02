using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guessnumber : MonoBehaviour
{
    private int randNum;
    [SerializeField] private int numeroJugador;
    [SerializeField] private int counter;

    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(1, 11);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            numeroJugador = int.Parse(GetComponent<InputField>().text);

            if (numeroJugador != randNum)
            {
                if (numeroJugador > randNum)
                {
                    Debug.Log(message: $"el numero es mas bajo");
                }
                else
                {
                    Debug.Log(message: $"el numero es mas alto");
                }
            }
            else
            {
                Debug.Log(message: $"Has acertado!");
                Debug.Log(message: $"Intentos: {counter}");
                Destroy(gameObject);
            }

            counter += 1;
        }
    }

   
}
