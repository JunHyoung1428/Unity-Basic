using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;


    float xInput=0;
    float zInput =0;
    float yInput=0;
    public float speed = 8.0f;
    public float jumpPower = 1.0f;

    Vector3 newVector;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        //yInput = Input.GetAxis("Jump");

        newVector = new Vector3(xInput*Time.deltaTime*speed, 0f, zInput*Time.deltaTime*speed);
        if (Input.GetKey(KeyCode.Space)==true)
        {
            playerRigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        if (newVector != Vector3.zero)
        {
            transform.position += newVector;
            playerRigidbody.transform.rotation =
                Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(newVector), Time.deltaTime * speed);
        }
    }

    public void Die()
    {
        //자신의 오브젝트 비활성화
        gameObject.SetActive(false);
    }
}
