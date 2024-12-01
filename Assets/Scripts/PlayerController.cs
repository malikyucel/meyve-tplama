using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private Rigidbody playerRB;
    private bool jump = true;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        // Player sað sol hareket konturolü
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.back * horizontalInput * Time.deltaTime * speed);
        //Vector3 haraker = new Vector3 (horizontalInput, 0, 0);
        //playerRB.AddForce(haraker * speed);

        // player jump konturol
        if (Input.GetKeyDown(KeyCode.W) && jump)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jump = false;
        }
        // player sýnýrlarý belirlendi
        if (transform.position.x < -5)
        {
            transform.position = new Vector3(-5, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 5)
        {
            transform.position = new Vector3(5, transform.position.y, transform.position.z);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        // Can azaltýr ve oyun bitirir
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Game Over !");
            Time.timeScale = 0;
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        // birden fazla zýplamayý konturol etmek için
        if (collision.gameObject.CompareTag("Zemin"))
        {
            jump = true;
        }
    }
}
