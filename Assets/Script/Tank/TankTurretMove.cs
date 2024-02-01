using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTurretMove : MonoBehaviour
{
    float rotationSpeed = 180.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TurretMoving();
    }

    void TurretMoving()
    { 
        Vector3 vector = Camera.main.transform.eulerAngles - transform.eulerAngles;
        float GapY = vector.y;
        vector.Normalize();
        float DesireY = 0f;

        if (Mathf.Abs(GapY) < 180)
        {
            DesireY += vector.y;    
        }else if (Mathf.Abs(GapY) > 180)
        {
            DesireY -= vector.y;
        }

        transform.Rotate(0f, DesireY * Time.deltaTime * rotationSpeed, 0f);
    }
}
