using UnityEngine;

public class FreezeOnCollision : MonoBehaviour
{
    [Tooltip("Finish")]
    public string collisionTag = "Finish"; // ������� ��� �������, ������� �������� ���������

    private Rigidbody rb;
    private bool isFrozen = false;

    void Start()
    {
        // �������� ��������� Rigidbody
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody component not found on " + gameObject.name);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // ��������� ��� �������������� �������
        if (collision.gameObject.CompareTag(collisionTag) && !isFrozen)
        {
            FreezeYPosition();
        }
    }

    void FreezeYPosition()
    {
        // ������������ ������� �� Y
        rb.constraints = RigidbodyConstraints.FreezePositionY | rb.constraints;
        isFrozen = true;

        // ����� ����� ���������� ��������, ���� �����
        // rb.constraints = RigidbodyConstraints.FreezeRotation | rb.constraints;

        //Debug.Log(gameObject.name + " frozen on Y axis");
    }

    // ����� ��� ���������� (���� �����)
    public void Unfreeze()
    {
        rb.constraints &= ~RigidbodyConstraints.FreezePositionY;
        isFrozen = false;
        Debug.Log(gameObject.name + " unfrozen on Y axis");
    }
}