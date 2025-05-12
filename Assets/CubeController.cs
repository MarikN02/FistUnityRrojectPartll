using UnityEngine;

public class CubeController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ГООООЛ!");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Штанга!!!!");
    }
}
