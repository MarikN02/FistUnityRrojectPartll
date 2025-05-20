using UnityEngine;
using UnityEngine.SceneManagement;

public class WinNextLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            // �������� ������ ������� �����
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            // ��������� ��������� ����� �� �������
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }
}