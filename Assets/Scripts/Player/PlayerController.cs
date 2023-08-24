using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public VariableJoystick moveJoystick;
    public VariableJoystick RotJoystick;
    public Rigidbody rb;

    private void FixedUpdate()
    {
        PlayerRotate();
        PlayerMove();
    }

    void PlayerMove()
    {
        Vector3 dir = Vector3.forward * moveJoystick.Vertical + Vector3.right * moveJoystick.Horizontal;
        rb.velocity = dir * speed;
    }

    void PlayerRotate()
    {
        if(RotJoystick.IsTouch)
        {
            Vector2 inputNor = RotJoystick.Direction.normalized;
            transform.eulerAngles = new Vector3(0f, Mathf.Atan2(inputNor.x, inputNor.y) * Mathf.Rad2Deg, 0f);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(this.transform.position, this.transform.localRotation * Vector3.forward * 20.0f);
    }
}
