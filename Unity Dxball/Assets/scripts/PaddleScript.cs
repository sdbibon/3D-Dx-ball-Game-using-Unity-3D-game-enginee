using UnityEngine;
using System.Collections;

public class PaddleScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(10f * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);
        
      
    }

    void OnCollisionEnter(Collision col)
    {
        foreach (ContactPoint contact in col.contacts)
        {
            if (contact.thisCollider == collider)
            {
                float english = contact.point.x - transform.position.x;
                contact.otherCollider.rigidbody.AddForce(300f * english, 0, 0);
            }
        }

    }
}
