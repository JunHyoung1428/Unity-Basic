using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public void GameStart()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single); //Single - �����ִ� �� �ݰ� �� ��, Additive ���� �� ���� �� ��
    }
}
