using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewTurretController : MonoBehaviour
{

    public GameObject shellPrefab;
    public Transform firePoint;

    public float fireSpeed = 500.0f;
    public float chargeSpeed = 100.0f;
    bool isFire;

    Vector3 newVector;
    float rotateSpeed = 60.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(newVector*Time.deltaTime*rotateSpeed);
        if(isFire)
        {
            fireSpeed += chargeSpeed * Time.deltaTime;
        }
    }

    void OnMoveTurret(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        newVector.y= input.x;
        newVector.x= input.y*-1;
    }

    void OnJump(InputValue value)
    {
        if (!isFire)
        {
            isFire = true;
        }
        else
        {
            Fire();
            isFire = false;
        }
    }
    void Fire()
    {
        firePoint = GameObject.FindWithTag("FirePoint").transform;
        GameObject shell = Instantiate(shellPrefab, firePoint.position, firePoint.rotation);
        Rigidbody bulletAddforce = shell.GetComponent<Rigidbody>();
        bulletAddforce.AddForce(firePoint.forward * fireSpeed);
        Destroy(shell, 5.0f);
        fireSpeed = 500.0f;
    }
}
