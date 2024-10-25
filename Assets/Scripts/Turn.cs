using UnityEngine;

public class Turn : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        transform.LookAt(other.transform.position);
    }
}
