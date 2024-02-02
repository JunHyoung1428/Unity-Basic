using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellController : MonoBehaviour
{
    float shellSpeed = 50.0f;
    public ParticleSystem explosion;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody>().AddForce(transform.forward * shellSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTrigger");
        explosion.transform.position = transform.position;
        explosion.transform.parent = null;
        explosion.Play();
        Destroy(gameObject);
    }
}
