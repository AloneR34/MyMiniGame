using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerControl : MonoBehaviour
{
    public GameObject player;
    public static double noise = 0.0;
    public Text texthym;
    public Rigidbody playerridg;
    public float speed;
    


    void Start()
    {
        playerridg = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    private void FixedUpdate()//50 раз в секунду обновл€етс€
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerridg.AddForce(0, 0, speed * Time.deltaTime);
            noise = noise + 0.02;//:50
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerridg.AddForce(0, 0, -speed * Time.deltaTime);
            noise = noise + 0.02;//:50
        }
        if (Input.GetKey(KeyCode.A))//!W
        {
            playerridg.AddForce(-speed * Time.deltaTime, 0, 0);
            noise = noise + 0.02;//:50
            }
        
        if (Input.GetKey(KeyCode.D))//!W
        {
            playerridg.AddForce(speed * Time.deltaTime, 0, 0);
            noise = noise + 0.01;//:50
        }
        else
        {
            noise = noise - 0.01;//:50 раз
        }

        if (noise > 10)
        {
            SceneManager.LoadScene("Endding");
            //¬раги догон€ют
        }
        if (noise <0)
        {
            noise = 0;
        }

        texthym.text = System.Math.Round(noise).ToString();
        
}
}
