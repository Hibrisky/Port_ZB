using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //임시
    public GameObject target;
    private Transform _cameraPos;
    private Vector3 offset = new Vector3(7, 15, -10);

    Renderer obstacleRenderer;


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

    //플레이어를 가린 물체(건물,차 등등) 반투명 시도..
    //void OtstacleRenderer()
    //{
    //    float distance = Vector3.Distance(transform.position, target.transform.position);
    //    Vector3 direction = (target.transform.position - transform.position).normalized;

    //    RaycastHit hit;
    //    if (Physics.Raycast(transform.position, direction, out hit, distance))
    //    {
    //        obstacleRenderer = hit.transform.gameObject.GetComponentInChildren<Renderer>();

    //        if(obstacleRenderer.tag == "Obstacle")
    //        {
    //            if (obstacleRenderer != null)
    //            {
    //                Material mat = obstacleRenderer.material;
    //                Color matColor = mat.color;
    //                matColor.a = 0.5f;
    //                mat.color = matColor;
    //            }
    //        }
    //    }
    //}
}
