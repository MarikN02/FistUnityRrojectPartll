using UnityEngine;

public class CubeController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("������!");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("������!!!!");
    }
}
