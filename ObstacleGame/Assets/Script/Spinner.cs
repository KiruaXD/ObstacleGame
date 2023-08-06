using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float x=0f, y=0f, z=0f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x, y, z);
    }
}
