using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreYazýsý;
    private int scoreSayýsý;
    // Start is called before the first frame update
    void Start()
    {
        scoreSayýsý = 0;
        scoreYazýsý.text = "Score: " + scoreSayýsý;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            scoreSayýsý++;
            scoreYazýsý.text = "Score: " + scoreSayýsý;
        }
    }
}
