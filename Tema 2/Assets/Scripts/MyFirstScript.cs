using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public int playerAge = 15;
    private float playerSpeed = 5.25f;
    public string playerName = "Dani";
    [SerializeField]
    private bool gameOver = false;
    [SerializeField] private int playerHP = 10;
    [SerializeField] private bool isCold;
    [SerializeField] private bool isRaining;




    // Start is called before the first frame update
    void Start()
    {
        /*
       if (playerHP > 0)
        {
            Debug.Log(message: "Sigues vivo");

        } 
        else
        {
            Debug.Log(message: "Estas Muerto");

        }

       if (playerAge < 13)
        {
            Debug.Log(message: "Eres un niño");
        } else if (playerAge < 18)
        { Debug.Log(message: "Eres adolescente");}
       else
        {
            Debug.Log(message: "Eres adulto");
        }
        */
        transform.position = new Vector3(x: 0, y: 0, z: 0);

        HelloWorld();
        HelloName("Maria");

        Debug.Log(message: Sum(1, 2));

        MoveGameObject(Vector3.right, KeyCode.D);
        MoveGameObject(Vector3.left, KeyCode.A);
        MoveGameObject(Vector3.up, KeyCode.E);
        MoveGameObject(Vector3.down, KeyCode.Q);
        MoveGameObject(Vector3.forward,KeyCode.W);
        MoveGameObject(Vector3.back, KeyCode.S);


    }

    // Update is called once per frame
    void Update()
    {
        /*
        
        if (isRaining == true)
        {
            
            if (isCold)
            {
                Debug.Log(message: "Lleva un paraguas y una sudadera");
            }
            else
            {
                Debug.Log(message: "Lleva un paraguas");
            }
        }
        else
        {
            Debug.Log(message: "No llueve");
        }
        

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += Vector3.down;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localScale += Vector3.right;
        }
        */
    }

    public void HelloWorld()
    {
        Debug.Log(message: "¡Hola mundo!");
    }

    public void HelloName(string name)
    {
        Debug.Log(message: $"Hola, {name}");
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
