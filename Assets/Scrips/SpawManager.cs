using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawManager : MonoBehaviour
{
    public static SpawManager instance;

    public float Speed;
    private void Start()
    {
        instance = this;
    }
}
