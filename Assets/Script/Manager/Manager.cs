using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Unity에서 컴포넌트에 싱글톤 패턴 적용하는 예


//Case: MonoBehaviour 상속하는 경우
public class Manager : MonoBehaviour
{    
    private static Manager Instance;
    public static Manager GetInstance() { return Instance; }

    [SerializeField] DataManager dataManager;
    public static DataManager Data { get {return Instance.dataManager;} }


    //private Manager() 
    // {
    //생성자를 Private으로 생성하더라도 MonoBehaviour를 상속 받기 때문에 의미가 없음
    //그냥 컴포넌트 여러번 가져다 붙이면 되기 때문(...)
    // }

    void Awake()//따라서 Awake에서 처리하는 방식을 사용함
    {
        Debug.Log("Manager Awake");
        if (Instance != null)
        {
            Destroy(this);//이미 존재했으면 스스로를 지움
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this); //다른씬으로 넘어가더라도 지워지지 않게 보장함
    }
    private void OnDestroy()
    {
        Debug.Log("SingleTon already exist");
    }
}
