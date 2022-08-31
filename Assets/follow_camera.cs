using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_camera : MonoBehaviour
{
    public Transform target;
    public float smoothValue;
    public float yOffset;
    public float xVelocity = 0.0f;
    public float yVelocity = 0.0f;

    public Transform GameObject;

 // UI.Text, doesnt work, GUIText obsolete, GameObject neither,, tried Transform but doesnt work either


    void Update()
    {
        
        float newX = Mathf.SmoothDamp(transform.position.x, target.position.x, ref xVelocity, smoothValue);
        float newY = Mathf.SmoothDamp(transform.position.y, target.position.y, ref yVelocity, smoothValue);
        
        transform.position = new Vector3 (newX, newY, -10);
    }
    
    void FixedUpdate()
    {
        GameObject.position = new Vector3(10f / (float)Screen.width, 10f / (float)Screen.height, 0f);
    }

}
