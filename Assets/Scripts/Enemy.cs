using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 20.0f;
    private Vector3 y�n = Vector3.back;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Enemy geli� konturol
        transform.Translate(y�n * speed * Time.deltaTime);
    }
    
    
}
