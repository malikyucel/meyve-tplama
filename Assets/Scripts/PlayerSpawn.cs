using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject[] PlayerSe�imi;
    public GameObject[] TextSe�im;
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
            Destroy(PlayerSe�imi[1]);
            Destroy(PlayerSe�imi[2]);

            Destroy(TextSe�im[0]);
            Destroy(TextSe�im[1]);
            Destroy(TextSe�im[2]);
            Time.timeScale = 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Destroy(PlayerSe�imi[0]);
            Destroy(PlayerSe�imi[2]);

            Destroy(TextSe�im[0]);
            Destroy(TextSe�im[1]);
            Destroy(TextSe�im[2]);
            Time.timeScale = 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Destroy(PlayerSe�imi[0]);
            Destroy(PlayerSe�imi[1]);

            Destroy(TextSe�im[0]);
            Destroy(TextSe�im[1]);
            Destroy(TextSe�im[2]);
            Time.timeScale = 1.0f;
        }
    }
}