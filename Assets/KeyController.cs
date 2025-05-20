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
    // Правильное объявление публичного метода
    public void DestroySomething()
    {
        // 1. Находим объект по тегу
        GameObject target = GameObject.FindWithTag("Ball");

        // 2. Проверяем, что объект найден
        if (target != null)
        {
            // 3. Уничтожаем объект
            Destroy(target);
        }
        else
        {
            Debug.LogWarning("Не найден объект с тегом 'Ball'");
        }
    }
}