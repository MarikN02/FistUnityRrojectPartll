using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 150f; // �������� ��������

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))   // ������� "�����"
            transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed);

        else if (Input.GetKey(KeyCode.RightArrow)) // ������� "������"
            transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed);

        if (Input.GetKey(KeyCode.DownArrow))     // ������� "����"
            transform.Rotate(Vector3.back * Time.deltaTime * rotationSpeed);

        else if (Input.GetKey(KeyCode.UpArrow))  // ������� "�����"
            transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
    }
}