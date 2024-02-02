using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyController : MonoBehaviour
{
    public GameObject dummy;
    public GameObject destroyed;
    public ParticleSystem explosion;

    private void OnCollisionEnter(Collision collision)
    {
        DummyDestroy();
    }

    private void OnTriggerEnter(Collider other)
    {
        DummyDestroy();
    }

    void DummyDestroy()
    {
        if (explosion != null)
        {
            dummy.SetActive(false);
            destroyed.SetActive(true);
            explosion.Play();
            explosion = null;
        }
    }
}
