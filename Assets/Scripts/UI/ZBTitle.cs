using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZBTitle : MonoBehaviour
{
 


    public void StartGame()
    {
        //로그인 필요.
        //임시 처리
        SceneManager.LoadSceneAsync("testSceneChange");
    }
}
