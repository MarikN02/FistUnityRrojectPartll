using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    [Tooltip("Тег объекта, который должен вызвать сообщение ГООООЛ!")]
    public string triggerTag = "Ball"; // Укажите тег объекта, который является мячом

    public AudioSource goalSound;

   



    void OnTriggerEnter(Collider other)
    {
        // Проверяем тег объекта, вошедшего в триггер
        if (other.CompareTag(triggerTag))
        {
            Debug.Log("ГООООЛ!");

            goalSound.Play();

            

            // Дополнительно можно вывести информацию об объекте
            Debug.Log("Объект " + other.name + " забил гол!");

        }
    }
    
}