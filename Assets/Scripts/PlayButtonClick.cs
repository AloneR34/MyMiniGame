using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButtonClick : MonoBehaviour
{
    //public GameObject[] sqares;
    //public int RandoMs;

    CubsHendler ex = new CubsHendler();
    public static void PlayClick2()
    {
        SceneManager.LoadScene("SampleScene");
        PlayerControl.noise = 0;//обнулила шум
    }

}


/*squares = new Transform[transform.childCount];
       int i = 0;

       foreach (Transform t in transform)
       {
           squ = this.gameObject.transform.GetChild(i);
           squ.gameObject.SetActive(true);
           squares[i++] = t;*/