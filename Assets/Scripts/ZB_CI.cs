using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZB_CI : MonoBehaviour
{
    public FadeController fader;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Activate());
    }

    IEnumerator Activate()
    {
        fader.FadeIn(0.7f);
        yield return new WaitForSeconds(3f);
        fader.FadeOut(0.6f, () =>
        {
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("2.Title");
        });
    }
   
}
