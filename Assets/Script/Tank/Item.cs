using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        /*TankController controller = collision.gameObject.GetComponent<TankController>();
        if (controller != null){}   //�̷������� �����ص� �ǰ�
        //if(collision.gameObject.layer == "Player") //���̾�� �����ص� ��
        if(collision.gameObject.tag == "Player") //�÷��̾�� �浹 ���� ���� ó���ϱ� ���� �±׸� ���� ����
        {
            Debug.Log("������ ȹ��");
            Destroy(gameObject);
        }*/
    }

    private void OnTriggerEnter(Collider other) //Is Trigger�� üũ�Ͽ� �浹�� ������, �浹 üũ(��ħ ����)�� ����
    {//�Ű������� Collison�� �ƴ϶� Collider �ӿ� ����
        if (other.gameObject.tag == "Player") 
        {
            Debug.Log("������ ȹ��");
            Destroy(gameObject);
        }
    }
}
