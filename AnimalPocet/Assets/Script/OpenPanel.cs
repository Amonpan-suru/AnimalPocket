using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {

    }

    public void open()
    {
        gameObject.transform.SetAsLastSibling();
        if (animator.GetBool("open"))
        {
            animator.SetBool("open", false);
        }
        else
        {
            animator.SetBool("open", true);
        }

    }
}
