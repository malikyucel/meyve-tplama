using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreYaz�s�;
    private int scoreSay�s�;
    // Start is called before the first frame update
    void Start()
    {
        scoreSay�s� = 0;
        scoreYaz�s�.text = "Score: " + scoreSay�s�;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            scoreSay�s�++;
            scoreYaz�s�.text = "Score: " + scoreSay�s�;
        }
    }
}