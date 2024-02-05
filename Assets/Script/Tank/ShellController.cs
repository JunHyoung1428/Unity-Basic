using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellController : MonoBehaviour
{
    public ParticleSystem explosion;

    private void OnCollisionEnter(Collision collision)
    {
        explosion.transform.parent = null;
        explosion.Play();
        Destroy(gameObject);
    }
}
