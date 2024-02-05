using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.GraphicsBuffer;

public class TankController : MonoBehaviour
{
    private new Rigidbody rigidbody; //new 
    public GameObject shellPrefab;
    private Transform[] other;

  
    public Transform firePoint;
    public float fireSpeed = 500.0f;

    private float moveSpeed = 8.0f;
    private float rotationSpeed = 60.0f;
    private float jumpForce = 7.0f;
    private float ShakeAmount = 0.5f;
    private float maxSpeed =10f;

    private WaitForSeconds cooltime = new WaitForSeconds(1.5f);
    private bool IsJump =false;


    Vector3 newVector;

    // Start is called before the first frame update
    void Start()
    {
       rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        //transform.Translate(0f,0f, newVector.x*Time.deltaTime*moveSpeed); //좌표 이동이라, 충돌 연산이 명확하지 않음, Rigidbody를 움직이는게 권장됨.
        transform.Rotate(0f, newVector.z* rotationSpeed*Time.deltaTime, 0f);
    }

    private void FixedUpdate()
    {
        Vector3 forceDir = transform.forward * newVector.x;
        rigidbody.AddForce(forceDir * moveSpeed*2, ForceMode.Force);

        if(rigidbody.velocity.magnitude > maxSpeed) //최고 속도 제한
        {
            rigidbody.velocity =rigidbody.velocity.normalized * maxSpeed;
        }
        //FixedUpdate 안에서 구현됨으로,초당 0.2회 호출이 보장됨으로 deltaTime을 안 곱해줘도 됨. 
    }

    void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        newVector.x = input.y;
        newVector.z = input.x;
    }

    void OnJump(InputValue value)
    {
        /*
        float jumpFlag = value.Get<float>();
        if (jumpFlag != 0 && !IsJump)
        {
            Debug.Log("OnJump");
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            IsJump = true;
            StartCoroutine(JumpCoolTime());
        }*/
    }

    void OnFire(InputValue value)
    {
        other = GetComponentsInChildren<Transform>();
        firePoint = other[6];
        GameObject shell = Instantiate(shellPrefab, firePoint.position, firePoint.rotation) as GameObject;
        Rigidbody bulletAddforce = shell.GetComponent<Rigidbody>();
        bulletAddforce.AddForce(firePoint.forward * 1000.0f);
        Destroy(shell, 5.0f);
    }

    IEnumerator JumpCoolTime()
    {
        yield return cooltime;
        IsJump = false;
    }
}
