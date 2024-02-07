using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single); //Single - �����ִ� �� �ݰ� �� ��, Additive ���� �� ���� �� ��
    }

    public void OnReturnTitle()
    {
       
       SceneManager.LoadScene("TitleScene");
    }
}
