using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    [Tooltip("��� �������, ������� ������ ������� ��������� ������!")]
    public string triggerTag = "Ball"; // ������� ��� �������, ������� �������� �����

    public AudioSource goalSound;

   



    void OnTriggerEnter(Collider other)
    {
        // ��������� ��� �������, ��������� � �������
        if (other.CompareTag(triggerTag))
        {
            Debug.Log("������!");

            goalSound.Play();

            

            // ������������� ����� ������� ���������� �� �������
            Debug.Log("������ " + other.name + " ����� ���!");

        }
    }
    
}