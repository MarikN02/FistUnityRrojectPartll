using UnityEngine;
using UnityEngine.SceneManagement;

// ��������� �����, ������������� �� �������� ����� ��� ����� �� ������
public class GetLevel3 : MonoBehaviour
{
    // ������� ���������� ������������� ��� ������� OnClick() ������
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
}