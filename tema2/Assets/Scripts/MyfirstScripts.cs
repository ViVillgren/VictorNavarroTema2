using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyfirstScripts : MonoBehaviour
{
    /*
   public int playerAge = 35;
   private float playerSpeed = 5.25f;
   
   [SerializeField] private bool gameOver;
    
    
    public string enemyName = "Victor ";

    public int hp = 100
    public 
    public int playerAge = 15;

    [SerializeField] private int x = 5;
    [SerializeField] private int y = 3;
    [SerializeField] private int z = 3;
    */
    [SerializeField] private bool isRaining;
    [SerializeField] private bool isCold;

    [SerializeField] private int playerHP = 10;
    public string playerName = "Victor";
    [SerializeField] private int x = 5;
    [SerializeField] private int y = 3;

    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log(playerAge);
        Debug.Log(message: $"Hola {playerName}");
        */
        /*
        Debug.Log( message: string.Format("Suma: {0} + {1} = {2}", x, y, x + y));
        Debug.Log( message: string.Format("Resta: {0} - {1} = {2}", x, y, x - y));
        Debug.Log( message: string.Format("Producto: {0} * {1} = {2}", x, y, x * y));
        Debug.Log( message: string.Format("Division: {0} / {1} = {2}", x, y, x / y));
        
        hp -= damage;
        hp = hp - damage
        if (playerName == enemyName)
        {
            Debug.Log( message: "Player y Enemy se llaman igual");

        }
        if (playerName != enemyName)
        {
            Debug.Log( message: "Player y Enemy tiene distinto nombre");

        }
        

        if (playerHP > 0)
        {
            Debug.Log(message: "Sigues Vivo");
        }
        else
        {
            Debug.Log(message: "Estas Muerto.");
        }
        

        if (playerAge < 13)
        {
            Debug.Log(message: "Eres un niño");
        }
        else if (playerAge < 18)
        {
            Debug.Log(message: "Eres adolescente");
        }
        else
        {
            Debug.Log(message: "Eres Adulto");
        }
    */
        //transform.position = new Vector3(0, 0, 0);
        transform.position = Vector3.zero;

        HelloWorld();
        HelloName(playerName);
        Debug.Log(message: GetHello());
        Debug.Log(message: $"{x} + {y} = {Sum(x, y)}");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation += new Quaternion.Euler(x: 0, y: 90, z: 0);
        }
        */

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localScale += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localScale -= Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.localScale += Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.localScale -= Vector3.up;
        }
        /*
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

        */

        MoveGameObject(Vector3.right, KeyCode.D);
        MoveGameObject(Vector3.left, KeyCode.A);
        MoveGameObject(Vector3.forward, KeyCode.W);
        MoveGameObject(Vector3.back, KeyCode.S);
        MoveGameObject(Vector3.up, KeyCode.Space);
        MoveGameObject(Vector3.down, KeyCode.X);

        /*
        if (isRaining == true)
        {

            if (isCold)
            {
                Debug.Log(message: "Llevate un paraguas y lleva una sudadera");

            }
            else
            {
                Debug.Log(message: "Llevate un paraguas");
            }
        }
        else
        {
            Debug.Log(message: "no llueve");
        }
        */
    }

    public void HelloWorld()
    {
        Debug.Log(message: "Hola, Mundo");
    }
    public void HelloName(string name)
    {
        Debug.Log(message: $"¡Hola, {name}!");
    }

    public string GetHello()
    {
        return "Hola";
    }

    public int Sum(int num1, int num2)

    {
        return num1 + num2;
    }

    public void MoveGameObject(Vector3 direction, KeyCode keyCode)
    {
        if (Input.GetKeyDown(keyCode))
        {
            transform.position += direction;
        }
    }

}
