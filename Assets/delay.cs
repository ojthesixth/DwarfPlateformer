using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delay : MonoBehaviour
{
    public Transform target;
    public float smoothValue;
    public float yOffset;
    public float xVelocity = 0.0f;
    public float yVelocity = 0.0f;


    void LateUpdate()
    {
        float newX = Mathf.SmoothDamp(transform.position.x, target.position.x, ref xVelocity, smoothValue);
        float newY = Mathf.SmoothDamp(transform.position.y, target.position.y, ref yVelocity, smoothValue);

        transform.position = new Vector3(newX, newY, -10);
    }

}
