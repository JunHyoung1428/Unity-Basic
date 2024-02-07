using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    [SerializeField] int fireCount;
    //int fireCount;
    public UnityAction<int> onFireChanged; //MVC예시 :  C#에서의 델리게이트 사용과 똑같음

    public int FireCount { get { return fireCount; } set { fireCount = value; onFireChanged?.Invoke(value); } } //값이 바뀌면 액션도 같이 작동해줌
    public void AddFireCount()
    {
        fireCount++;
        // 다른 스크립트의 Fire() 함수에서 Manager.Data.AddFireCount(); 해서 사용
    }
}
