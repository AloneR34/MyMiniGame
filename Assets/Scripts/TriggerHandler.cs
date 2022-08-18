using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TriggerHandler : MonoBehaviour
{
    public Rigidbody danger1rridg;
    public Rigidbody danger2rridg;

    int speed = 1000;

        //Destroy(other.gameObject);
        void OnTriggerEnter(Collider other)
        {
        if (other.gameObject.CompareTag("danderTag")) //тег  врага

        {
            danger1rridg.AddForce(-speed * Time.deltaTime, 0, 0);
            danger2rridg.AddForce(-speed * Time.deltaTime, 0, 0);
        }

        if (other.gameObject.CompareTag("PlayerTag")) //тег  игрока

        {
            SceneManager.LoadScene("Beggin");
        }
    }
}
