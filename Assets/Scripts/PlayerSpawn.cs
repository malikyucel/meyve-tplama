using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject[] PlayerSešimi;
    public GameObject[] TextSešim;
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
            Destroy(PlayerSešimi[1]);
            Destroy(PlayerSešimi[2]);

            Destroy(TextSešim[0]);
            Destroy(TextSešim[1]);
            Destroy(TextSešim[2]);
            Time.timeScale = 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Destroy(PlayerSešimi[0]);
            Destroy(PlayerSešimi[2]);

            Destroy(TextSešim[0]);
            Destroy(TextSešim[1]);
            Destroy(TextSešim[2]);
            Time.timeScale = 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Destroy(PlayerSešimi[0]);
            Destroy(PlayerSešimi[1]);

            Destroy(TextSešim[0]);
            Destroy(TextSešim[1]);
            Destroy(TextSešim[2]);
            Time.timeScale = 1.0f;
        }
    }
}
