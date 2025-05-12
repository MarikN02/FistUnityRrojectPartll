using UnityEngine;

public class OverLapConrtoller : MonoBehaviour
{
    public float rad;
    public LayerMask layerM;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] colls = Physics.OverlapSphere(transform.position, rad, layerM);

        foreach (Collider coll in colls)
        {
            //coll.gameObject.transform.localScale *= 3f;
            Destroy(coll.gameObject);
            Debug.Log(coll.name);
        }
    }
}
