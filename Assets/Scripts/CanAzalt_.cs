using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CanAzalt_ : MonoBehaviour
{
    public GameObject[] Can_123;
    int Azalt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin") && Azalt == 2)
        {
            Azalt += 1;
            Destroy(Can_123[2]);
            Time.timeScale = 0;
        }
        if (other.gameObject.CompareTag("Coin") && Azalt == 1)
        {
            Azalt += 1;
            Destroy(Can_123[1]);
        }
        if (other.gameObject.CompareTag("Coin") && Azalt == 0)
        {
            Azalt += 1;
            Destroy(Can_123[0]);
        }
        
    }

}
