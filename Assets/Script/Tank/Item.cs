using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        /*TankController controller = collision.gameObject.GetComponent<TankController>();
        if (controller != null){}   //이런식으로 검증해도 되고
        //if(collision.gameObject.layer == "Player") //레이어로 검증해도 됨
        if(collision.gameObject.tag == "Player") //플레이어와 충돌 했을 때만 처리하기 위해 태그를 통해 검증
        {
            Debug.Log("아이템 획득");
            Destroy(gameObject);
        }*/
    }

    private void OnTriggerEnter(Collider other) //Is Trigger에 체크하여 충돌은 없지만, 충돌 체크(겹침 여부)만 가능
    {//매개변수가 Collison이 아니라 Collider 임에 유의
        if (other.gameObject.tag == "Player") 
        {
            Debug.Log("아이템 획득");
            Destroy(gameObject);
        }
    }
}
