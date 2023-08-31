using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    Light _light;
    float deltaTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        _light = GetComponent<Light>();
        StartCoroutine(Co_LightEffect());
    }
    
    IEnumerator Co_LightEffect()
    {
        while(true)
        {
            _light.range = 7;
            yield return new WaitForSeconds(0.05f);
            _light.range = 0;
            yield return new WaitForSeconds(0.05f);
            _light.range = 7;
            yield return new WaitForSeconds(0.05f);
            _light.range = 0;
            yield return new WaitForSeconds(0.05f);
            _light.range = 7;
            yield return new WaitForSeconds(0.7f);
            _light.range = 0;
            yield return new WaitForSeconds(1.0f);
            _light.range = 7;
        }
    }
}
