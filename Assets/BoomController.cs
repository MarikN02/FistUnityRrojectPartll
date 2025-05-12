using UnityEngine;

public class BoomController : MonoBehaviour
{
    public float TimerToExplosion;
    public float Power;
    public float Radius;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimerToExplosion -= Time.deltaTime;

        if (TimerToExplosion <= 0)
        {
            Boom();
        }
    }
    void Boom()
    {
        Rigidbody[] blocks = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody b in blocks)
        {
            if (Vector3.Distance(transform.position, b.transform.position) < Radius)
            {
                Vector3 direction = b.transform.position - transform.position;

                b.AddForce(direction.normalized * Power * (Radius - Vector3.Distance(transform.position, b.transform.position)), ForceMode.Impulse);
            }
               
        }




        TimerToExplosion = 3;
    }
}
