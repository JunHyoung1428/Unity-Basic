using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FireCountView : MonoBehaviour
{
    public TMP_Text text;
    private void UpdateView(int value)
    {
        Debug.Log("UpdateView");
        text.text = value.ToString();    //View는 값 갱신만
    }


    private void OnEnable()
    {   // OnEnable()이 Manager의 Awake()보다 일찍 호출되면 NullReferenceException 에러 발생 (참고:https://velog.io/@wjdgh9577/Awake-OnEnable%EC%9D%98-%ED%98%B8%EC%B6%9C-%EC%88%9C%EC%84%9C%EB%8A%94-%EB%B3%B4%EC%9E%A5%EB%90%98%EC%A7%80-%EC%95%8A%EB%8A%94%EB%8B%A4)
        // 일단 Update로 해주자...
        Debug.Log("FireCountView OnEnable");
        UpdateView(Manager.Data.FireCount);
        Manager.Data.onFireChanged += UpdateView;
    }

    private void OnDisable()
    {
        Manager.Data.onFireChanged -= UpdateView;
    }

}
