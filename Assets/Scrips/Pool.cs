using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
  //  public Transform parent;
    
    private void Update()
    {
        transform.Translate(Vector3.left * SpawManager.instance.Speed*Time.deltaTime);
    }
}
