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

    new Rigidbody rigidbody; // 앞에 new 붙여서 C# 의 하이딩
    private void ThisFuntion()
    {
        // <현재 게임 오브젝트 참조>
        //컴포넌트가 붙어있는 게임 오브젝트는 Component에서 구현한 gameObject 프로퍼티로 get 
        thisGameObject = gameObject; 
        thisName = thisGameObject.name; //오브젝트의 이름
        thisActive = thisGameObject.activeSelf; // 오브젝트의 활성화 여부
        thisActive = thisGameObject.activeInHierarchy; // 하이어라키상(씬)에서 활성화 여부
        thisTag = thisGameObject.tag; 
        thisLayer = thisGameObject.layer;   
    }

    private void GameObjectFunction()
    {
        // 새로운 게임 오브젝트 생성
        newGameObject = new GameObject("NewGameObject");

        // 게임 오브젝트 삭제
        if(destroyedGameObject != null)
        {
            Destroy(destroyedGameObject, 3f) ; //3초뒤 지연 삭제
        }

        //게임 오브젝트 이름으로 검색
        findWithName = GameObject.Find("Main Camera");
        findWithName = GameObject.FindWithTag("MainCamera"); //태그로 찾기, 태그로 찾는것을 권장함
       
    }

    void ComponetFunction()
    {
        //<컴포넌트 추가>
       // newComponent = new Rigidbody(); // 생성하는 것은 아무 의미 없음, 컴포넌트는 게임 오브젝트에 부착되어있을 때 의미 있기 때문.
       newComponent = gameObject.AddComponent<Rigidbody>(); // 게임 오브젝트에 추가해서 사용

        //<컴포넌트 삭제>
        if(newComponent != null)
        {
            Destroy(newComponent);
        }
        
        //<컴포넌트 탐색>
        //같은 게임 오브젝트에서 찾기
        getCompoent = gameObject.GetComponent<Collider>(); //인터페이스도 탐색 가능

        //씬에서 찾기
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
