using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //임시
    public GameObject target;

    private Transform _cameraPos;

    private Vector3 offset = new Vector3(7,15,-10);

    // Start is called before the first frame update
    void Start()
    {
        if (_cameraPos == null)
            _cameraPos = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        CameraMove();
    }


    void CameraMove()
    {
        //카메라 시점 처리.
        _cameraPos.transform.position = target.transform.position + offset;
        _cameraPos.transform.LookAt(target.transform);
    }
}
