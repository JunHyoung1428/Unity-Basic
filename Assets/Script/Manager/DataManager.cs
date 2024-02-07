using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    [SerializeField] int fireCount;
    //int fireCount;
    public UnityAction<int> onFireChanged; //MVC���� :  C#������ ��������Ʈ ���� �Ȱ���

    public int FireCount { get { return fireCount; } set { fireCount = value; onFireChanged?.Invoke(value); } } //���� �ٲ�� �׼ǵ� ���� �۵�����
    public void AddFireCount()
    {
        fireCount++;
        // �ٸ� ��ũ��Ʈ�� Fire() �Լ����� Manager.Data.AddFireCount(); �ؼ� ���
    }
}
