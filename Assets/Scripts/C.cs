using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class C : MonoBehaviour
{
    public GameObject player;
    public static double hym =0.0;
    public Text texthym;
    public Rigidbody playerridg;
    public float speed;
    


    void Start()
    {
        playerridg = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    private void FixedUpdate()//50 раз в секунду обновляется
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerridg.AddForce(0, 0, speed * Time.deltaTime);
            //player.transform.position += (new Vector3(0, 1)*Time.deltaTime);
            hym = hym + 0.03;//:50
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerridg.AddForce(0, 0, -speed * Time.deltaTime);
            //player.transform.position += (new Vector3(0, -1) * Time.deltaTime);
            hym = hym + 0.03;//:50
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerridg.AddForce(-speed * Time.deltaTime, 0, 0);
            //player.transform.position += (new Vector3(-1, 0) * Time.deltaTime);
            hym = hym + 0.03;//:50
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerridg.AddForce(speed * Time.deltaTime, 0, 0);
            //player.transform.position += (new Vector3(1, 0) * Time.deltaTime);
            hym = hym + 0.03;//:50
        }
        else
        {
            hym = hym - 0.01;//:50 раз
        }

        if (hym > 10)
        {
            SceneManager.LoadScene("Endding");
        }

        texthym.text = hym.ToString();
    }
}
