using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canBar : MonoBehaviour
{

    public GameObject canbar;
    public float can;
    // Start is called before the first frame update
    void Start()
    {
        can = 100;
    }

    // Update is called once per frame
    void Update()
    {
        canbar.transform.localScale= new Vector3(can/100, 1, 1);

        if (can >= 100)
        {
            can = 100;
        }

        if (can <= 0)
        {
            can = 0;
        }


    }
}
