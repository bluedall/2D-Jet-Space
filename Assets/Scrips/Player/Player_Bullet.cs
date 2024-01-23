using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet : MonoBehaviour
{
    [SerializeField] ParticleSystem particle;
    [SerializeField] AudioClip Clip;
    private void OnParticleCollision(GameObject other)
    {
        print("OnParticleCollision");

        other.GetComponent<Enemy_Health>().Health-=1;
    }

   

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            particle.Play();
            SoundManager.instance.PlaySound(Clip);
        }
    }
}
