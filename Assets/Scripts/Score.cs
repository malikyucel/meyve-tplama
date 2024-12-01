using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreYazısı;
    private int scoreSayısı;
    // Start is called before the first frame update
    void Start()
    {
        scoreSayısı = 0;
        scoreYazısı.text = "Score: " + scoreSayısı;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            scoreSayısı++;
            scoreYazısı.text = "Score: " + scoreSayısı;
        }
    }
}
