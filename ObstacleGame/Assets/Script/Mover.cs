using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        //transform.Translate(1, 0, 0);
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
    }

    void MovePlayer()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(x, 0, z);
    }
}
