using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    private Animator Anim;

    private void Awake()
    {
        Anim = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        Anim.SetBool("Alive", false);
        Anim.SetTrigger("Collect");
        Destroy(this, 0.7f);
    }
    // ���������� ���������� ���������� ������
    public void DestroySomething()
    {
        // 1. ������� ������ �� ����
        GameObject target = GameObject.FindWithTag("Ball");

        // 2. ���������, ��� ������ ������
        if (target != null)
        {
            // 3. ���������� ������
            Destroy(target);
        }
        else
        {
            Debug.LogWarning("�� ������ ������ � ����� 'Ball'");
        }
    }
}