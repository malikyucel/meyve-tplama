using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject[] PlayerSeçimi;
    public GameObject[] TextSeçim;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Destroy(PlayerSeçimi[1]);
            Destroy(PlayerSeçimi[2]);

            Destroy(TextSeçim[0]);
            Destroy(TextSeçim[1]);
            Destroy(TextSeçim[2]);
            Time.timeScale = 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Destroy(PlayerSeçimi[0]);
            Destroy(PlayerSeçimi[2]);

            Destroy(TextSeçim[0]);
            Destroy(TextSeçim[1]);
            Destroy(TextSeçim[2]);
            Time.timeScale = 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Destroy(PlayerSeçimi[0]);
            Destroy(PlayerSeçimi[1]);

            Destroy(TextSeçim[0]);
            Destroy(TextSeçim[1]);
            Destroy(TextSeçim[2]);
            Time.timeScale = 1.0f;
        }
    }
}
