using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Animator Anim;

    public float speed;
    float hAxis;
    float vAxis;
    bool wDown;

    Vector3 moveVec;

    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {

        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
        wDown = Input.GetButton("Walk");

            moveVec = new Vector3(hAxis, 0, vAxis).normalized;
            transform.position += moveVec * speed * Time.deltaTime;

        Anim.SetBool("isWalk", moveVec != Vector3.zero);
        Anim.SetBool("isRun", wDown);

    }
}
