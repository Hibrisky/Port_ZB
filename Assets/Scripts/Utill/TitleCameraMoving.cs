using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleCameraMoving : MonoBehaviour
{
    public GameObject objPoint;
    public float rotateSpeed = 20f;
    void Update()
    {
        this.gameObject.transform.RotateAround(objPoint.transform.position, Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
