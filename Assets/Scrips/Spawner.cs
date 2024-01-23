using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] gameobject;
    [SerializeField] float SpawnTime_Repeat;
    void Start()
    {
        InvokeRepeating("SpawnGameObject", 1, SpawnTime_Repeat);
    }


    int i;
    void SpawnGameObject()
    {
    
        if (i==gameobject.Length)
        {
            i = 0;
        }

        //  gameobject[i].transform.parent = null;
        if (gameobject[i].activeSelf==false)
        {            
            gameobject[i].SetActive(true);
            gameobject[i].transform.position = transform.position;
        }
       
        i += 1;
    }
}
