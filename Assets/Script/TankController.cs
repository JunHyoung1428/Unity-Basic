using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{
    private Rigidbody rigidbody;
   

    private float moveSpeed = 8.0f;
    private float rotationSpeed = 60.0f;
    private float jumpForce = 5f;
    private float ShakeAmount = 0.5f;

    Vector3 newVector;

    // Start is called before the first frame update
    void Start()
    {
       rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        transform.Translate(0f,0f, newVector.x*Time.deltaTime*moveSpeed);
        transform.Rotate(0f, newVector.z* rotationSpeed*Time.deltaTime, 0f);
    }

    void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        newVector.x = input.y;
        newVector.z = input.x;
    }

    void OnJump(InputValue value)
    {
        float jumpFlag = value.Get<float>();
        if (jumpFlag != 0)
        {
            Debug.Log("OnJump");
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void OnFire(InputValue value)
    {
        //Camera.main.transform.position = Random.insideUnitSphere * ShakeAmount + Camera.main.transform.position; 
    }

   

}
