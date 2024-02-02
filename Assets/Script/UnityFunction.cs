using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityFunction : MonoBehaviour
{
    [Header("This")]
    public GameObject thisGameObject;
    public string thisName;
    public bool thisActive;
    public string thisTag;
    public int thisLayer;

    [Header("GameObject")]
    public GameObject newGameObject;
    public GameObject destroyedGameObject;
    public GameObject findWithName;

    [Header("Component")]
    public Component newComponent;
    public Component getCompoent;
    public Component findComponet;

    new Rigidbody rigidbody; // �տ� new �ٿ��� C# �� ���̵�
    private void ThisFuntion()
    {
        // <���� ���� ������Ʈ ����>
        //������Ʈ�� �پ��ִ� ���� ������Ʈ�� Component���� ������ gameObject ������Ƽ�� get 
        thisGameObject = gameObject; 
        thisName = thisGameObject.name; //������Ʈ�� �̸�
        thisActive = thisGameObject.activeSelf; // ������Ʈ�� Ȱ��ȭ ����
        thisActive = thisGameObject.activeInHierarchy; // ���̾��Ű��(��)���� Ȱ��ȭ ����
        thisTag = thisGameObject.tag; 
        thisLayer = thisGameObject.layer;   
    }

    private void GameObjectFunction()
    {
        // ���ο� ���� ������Ʈ ����
        newGameObject = new GameObject("NewGameObject");

        // ���� ������Ʈ ����
        if(destroyedGameObject != null)
        {
            Destroy(destroyedGameObject, 3f) ; //3�ʵ� ���� ����
        }

        //���� ������Ʈ �̸����� �˻�
        findWithName = GameObject.Find("Main Camera");
        findWithName = GameObject.FindWithTag("MainCamera"); //�±׷� ã��, �±׷� ã�°��� ������
       
    }

    void ComponetFunction()
    {
        //<������Ʈ �߰�>
       // newComponent = new Rigidbody(); // �����ϴ� ���� �ƹ� �ǹ� ����, ������Ʈ�� ���� ������Ʈ�� �����Ǿ����� �� �ǹ� �ֱ� ����.
       newComponent = gameObject.AddComponent<Rigidbody>(); // ���� ������Ʈ�� �߰��ؼ� ���

        //<������Ʈ ����>
        if(newComponent != null)
        {
            Destroy(newComponent);
        }
        
        //<������Ʈ Ž��>
        //���� ���� ������Ʈ���� ã��
        getCompoent = gameObject.GetComponent<Collider>(); //�������̽��� Ž�� ����

        //������ ã��
        findComponet = Component.FindObjectOfType<Camera>();

    }
    // Start is called before the first frame update
    void Start()
    {
        ThisFuntion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
