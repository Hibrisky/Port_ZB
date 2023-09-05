using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //�ӽ�
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
        //ī�޶� ���� ó��.
        _cameraPos.transform.position = target.transform.position + offset;
        _cameraPos.transform.LookAt(target.transform);
    }

    //�÷��̾ ���� ��ü(�ǹ�,�� ���) ������ �õ�..
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
