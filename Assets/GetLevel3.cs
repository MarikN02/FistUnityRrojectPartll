using UnityEngine;
using UnityEngine.SceneManagement;

// Назначаем класс, ответственный за загрузку сцены при клике на кнопку
public class GetLevel3 : MonoBehaviour
{
    // Функция вызывается автоматически при событии OnClick() кнопки
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
}