using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZBTitle : MonoBehaviour
{
 


    public void StartGame()
    {
        //�α��� �ʿ�.
        //�ӽ� ó��
        SceneManager.LoadSceneAsync("testSceneChange");
    }
}
