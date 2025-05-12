using UnityEngine;

public class FreezeOnCollision : MonoBehaviour
{
    [Tooltip("Finish")]
    public string collisionTag = "Finish"; // Укажите тег объекта, который вызывает заморозку

    private Rigidbody rb;
    private bool isFrozen = false;

    void Start()
    {
        // Получаем компонент Rigidbody
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody component not found on " + gameObject.name);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Проверяем тег столкнувшегося объекта
        if (collision.gameObject.CompareTag(collisionTag) && !isFrozen)
        {
            FreezeYPosition();
        }
    }

    void FreezeYPosition()
    {
        // Замораживаем позицию по Y
        rb.constraints = RigidbodyConstraints.FreezePositionY | rb.constraints;
        isFrozen = true;

        // Можно также заморозить вращение, если нужно
        // rb.constraints = RigidbodyConstraints.FreezeRotation | rb.constraints;

        //Debug.Log(gameObject.name + " frozen on Y axis");
    }

    // Метод для разморозки (если нужно)
    public void Unfreeze()
    {
        rb.constraints &= ~RigidbodyConstraints.FreezePositionY;
        isFrozen = false;
        Debug.Log(gameObject.name + " unfrozen on Y axis");
    }
}