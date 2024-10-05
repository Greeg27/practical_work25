using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalHandler : MonoBehaviour
{
    private Rigidbody rb;

    public void SizeExchange()
    {
        transform.localScale = Vector3.one * 2;

        ForceAdd();
    }

    private void ForceAdd() 
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * 3000);
    }

    public void Destroy()
    {
        Destroy(this.gameObject);
    }
}
