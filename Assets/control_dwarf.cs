using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_dwarf : MonoBehaviour
{   public float _speed = 10f;
    public GameObject Dwarf;
    public Rigidbody2D _rigidbody;


    void Start()
    {
        
    }

    void Update()
    {

     float v = Input.GetAxis("Horizontal") * _speed;
        _rigidbody.velocity = new Vector3();


    }
}
