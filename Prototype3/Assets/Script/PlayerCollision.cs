using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameManager gameManager;

    public bool line1Played;
    public bool line2Played;
    public bool line3Played;
    public bool line4Played;
    public bool line5Played;
    public bool line6Played;
    public bool line7Played;
  

    // Start is called before the first frame update
    void Start()
    {
        line1Played = false;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "Heartbeat")
        {
            FindObjectOfType<AudioManager>().Play("Heartbeat");
            Destroy(collision.gameObject);
            //Debug.Log("After Dark!");
            
        }
       
        if (collision.gameObject.tag == "Abyss")
        {
           
            Destroy(collision.gameObject);
            Debug.Log("Ending");
            FindObjectOfType<GameManager>().EndGame();

        }

        if (collision.gameObject.tag == "Line1")
        {
            line1Played = true;
            FindObjectOfType<AudioManager>().Play("Line1");
            Destroy(collision.gameObject);
            Debug.Log("Line 1");
           
        }
        if (collision.gameObject.tag == "Line2")
        {
            line2Played = true;
            FindObjectOfType<AudioManager>().Play("Line2");
            Destroy(collision.gameObject);
            Debug.Log("Line 2");

        }
        if (collision.gameObject.tag == "Line3")
        {
            line3Played = true;
            FindObjectOfType<AudioManager>().Play("Line3");
            Destroy(collision.gameObject);
            Debug.Log("Line 3");

        }
        if (collision.gameObject.tag == "Line4")
        {
            line4Played = true;
            FindObjectOfType<AudioManager>().Play("Line4");
            Destroy(collision.gameObject);
            Debug.Log("Line 4");

        }
        if (collision.gameObject.tag == "Line5")
        {
            line5Played = true;
            FindObjectOfType<AudioManager>().Play("Line5");
            Destroy(collision.gameObject);
            Debug.Log("Line 5");

        }
        if (collision.gameObject.tag == "Line6")
        {
            line6Played = true;
            FindObjectOfType<AudioManager>().Play("Line6");
            Destroy(collision.gameObject);
            Debug.Log("Line 6 ");

        }

        if (collision.gameObject.tag == "Line7")
        {
            line7Played = true;
            FindObjectOfType<AudioManager>().Play("Line7");
            Destroy(collision.gameObject);
            Debug.Log("Line 7 ");

        }

        if (line1Played && line2Played && line3Played && line4Played && line5Played && line6Played && line7Played)
        {
            FindObjectOfType<AudioManager>().Play("AfterDark");
            line1Played = false;
        }

        if (collision.gameObject.tag == "Space")
        {
        
            FindObjectOfType<AudioManager>().Play("Space");
            Destroy(collision.gameObject);
            Debug.Log("Sounds like home");
        }

        if (collision.gameObject.tag == "Wind")
        {
            FindObjectOfType<AudioManager>().Play("Wind");
            Destroy(collision.gameObject);
            Debug.Log("The wind howls");
        }

        if (collision.gameObject.tag == "LastLine")
        {
            FindObjectOfType<AudioManager>().Play("LastLine");
            Destroy(collision.gameObject);
            Debug.Log("Jump. Please.");
        }
    }
}
