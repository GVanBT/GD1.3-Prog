using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public Animator m_Animator;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m_Animator.ResetTrigger("Run");
            m_Animator.ResetTrigger("Idle");

            m_Animator.SetTrigger("Jump");
        }

        if (Input.GetKey(KeyCode.D))
        {
            m_Animator.ResetTrigger("Jump");
            m_Animator.ResetTrigger("Idle");

            m_Animator.SetTrigger("Run");
        }

        if (Input.GetKey(KeyCode.S))
        {
            m_Animator.ResetTrigger("Jump");
            m_Animator.ResetTrigger("Run");

            m_Animator.SetTrigger("Idle");
        }
    }
}
