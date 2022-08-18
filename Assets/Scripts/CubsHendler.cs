using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubsHendler : MonoBehaviour

{
   // public GameObject[] cubs;
    public int RandoMs;
    public int CountCubs = 0;
    public GameObject cub;
    public int k = 0;

    private void Start()
    {
        OnClick();
    }

    public void OnClick()
    {
        for (int i = -45; i <= 45; i = i + 10)
        {
            for (int j = 45; j >= -45; j = j - 10)
            {
                if ((i==45)||(i==-45)||(j==-45)||(j==45)||(i==-5)||(j==5))//Первые строки от стен свободные
                { }
                else
                {
                    int CountCubs2 = Random.Range(10, 35);
                    if (CountCubs < CountCubs2)
                    {
                        RandoMs = Random.Range(1, 3);
                        if (RandoMs == 1)
                        {
                            var randomPosition = new Vector3(i, 5, j);
                            var clone = Instantiate(cub, randomPosition, Quaternion.identity) as GameObject;
                            //cubs[k] = clone;
                           // k++;
                            CountCubs++;
                        }
                        if (RandoMs == 2)
                        {
                            //Пустое пространство
                        }
                        RandoMs = 0;
                    }
                }
            }
        }
        /*for (int x = 0; x < sqares.Length; x++)
        {
            RandoMs = Random.Range(1, 3);
            if (RandoMs == 1)
            {
                sqares[x].SetActive(false);
            }
            if (RandoMs == 2)
            {
                sqares[x].SetActive(true);
            }
            RandoMs = 0;
        }*/
    }
}

