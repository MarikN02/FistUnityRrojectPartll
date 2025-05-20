using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectL2 : MonoBehaviour
{
    public float rotationSpeed2 = 700f; // �������� ��������

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))   // ������� "�����"
            transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed2);

        else if (Input.GetKey(KeyCode.RightArrow)) // ������� "������"
            transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed2);

        if (Input.GetKey(KeyCode.DownArrow))     // ������� "����"
            transform.Rotate(Vector3.back * Time.deltaTime * rotationSpeed2);

        else if (Input.GetKey(KeyCode.UpArrow))  // ������� "�����"
            transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed2);
    }
}