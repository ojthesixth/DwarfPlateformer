using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_dwarf : MonoBehaviour
{
    private float controlDwarf;
    public float _speed = 10f;
    public GameObject Dwarf;
    public Rigidbody2D _rigidbody;
    public CapsuleCollider2D _collider2D;
    public Animator _animator;
    public float GravityScaleOnFall;
    public Vector3 direction;

    public float walkingSpeed;
    [Header("jump")]
    public bool isJumping = false;
    public byte currentJumpCount = 0;
    //public int jumpPower = 1000;
    private float _jumpForce = 200f;
    private float _fallMutiplier = 3f;

    [Range(1, 10)]
    public float jumpVelocity;
    public GameObject graphics;


    void Awake() {

        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = graphics.GetComponent<Animator>();
    }

    void Start()
    {

    }

    void Update()
    {

        controlDwarf = Input.GetAxisRaw("Horizontal");
        _rigidbody.velocity = new Vector3(controlDwarf * _speed, _rigidbody.velocity.y);

        //part of attempt1
        /* if (Input.GetButtonDown("Jump"))
            {
                isJumping = true;
            }

        }*/

        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.up * jumpVelocity;
        }

        if (direction.x < 0f)
        {
            graphics.transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            graphics.transform.localScale = new Vector3(1, 1, 1);
        }

        _animator.SetFloat("MoveSpeedx", Mathf.Abs(direction.x));
        _animator.SetFloat("MoveSpeedy", _rigidbody.velocity.y);

    } 


    void fixedUpdate()
        {

          
        //attempt1 at jump
         direction.y = _rigidbody.velocity.y;

        if (isJumping)
        {
            direction.y = _jumpForce * Time.fixedDeltaTime;
            isJumping = false;
        }
        if(_rigidbody.velocity.y < 0)
        {
            _rigidbody.gravityScale = _fallMutiplier;
        }
        else
        {
            _rigidbody.gravityScale = 1f;
        }

        _rigidbody.velocity = direction;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       /* if (collision.collider.CompareTag("Floor"))
        {
            _nbJump = 0;
        }
        */
    }

}
