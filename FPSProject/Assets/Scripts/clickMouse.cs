using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickMouse : MonoBehaviour {
    private Animator animator;
    
    void Awake()
    {
        animator = this.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            animator.Play("shoot");
    }
}
