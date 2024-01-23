using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    public float Health;
    [HideInInspector]public float DefualtHealth;
    
    private void OnEnable()
    {
        DefualtHealth = Health;
    }
    private void OnDisable()
    {
        Health= DefualtHealth;
    }
    void Update()
    {
        if (Health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
