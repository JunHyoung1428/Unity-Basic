using UnityEngine;
using UnityEngine.InputSystem;

public class NewTurretController : MonoBehaviour
{
    Vector3 newVector;
    float rotateSpeed = 60.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(newVector * Time.deltaTime * rotateSpeed);
    }
    void OnMoveTurret(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        newVector.y = input.x;
        newVector.x = input.y * -1;
    }
}
