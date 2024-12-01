using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SahneHaraketi : MonoBehaviour
{
    public float speed = 20.0f;
    private Vector3 yön = Vector3.back;
    public GameObject plane;
    private bool off = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Enemy geliþ konturol
        transform.Translate(yön * speed * Time.deltaTime);
        // Sahne tekrarlama 
        if (transform.position.z < 3.0f && off)
        {
            Instantiate(plane, new Vector3(0,0,203), plane.transform.rotation);
            off = false;

        }
        if (transform.position.z < -108)
        {
            Destroy(gameObject);
        }
    }
}
