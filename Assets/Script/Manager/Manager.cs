using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Unity���� ������Ʈ�� �̱��� ���� �����ϴ� ��


//Case: MonoBehaviour ����ϴ� ���
public class Manager : MonoBehaviour
{    
    private static Manager Instance;
    public static Manager GetInstance() { return Instance; }

    [SerializeField] DataManager dataManager;
    public static DataManager Data { get {return Instance.dataManager;} }


    //private Manager() 
    // {
    //�����ڸ� Private���� �����ϴ��� MonoBehaviour�� ��� �ޱ� ������ �ǹ̰� ����
    //�׳� ������Ʈ ������ ������ ���̸� �Ǳ� ����(...)
    // }

    void Awake()//���� Awake���� ó���ϴ� ����� �����
    {
        Debug.Log("Manager Awake");
        if (Instance != null)
        {
            Destroy(this);//�̹� ���������� �����θ� ����
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this); //�ٸ������� �Ѿ���� �������� �ʰ� ������
    }
    private void OnDestroy()
    {
        Debug.Log("SingleTon already exist");
    }
}
