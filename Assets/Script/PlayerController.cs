using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 8.0f;

    Vector3 newVector;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        newVector = new Vector3(xSpeed, 0f, zSpeed);

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
