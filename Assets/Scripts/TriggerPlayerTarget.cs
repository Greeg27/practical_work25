using UnityEngine;

public class TriggerPlayerTarget : MonoBehaviour
{
    [SerializeField] PlayerControl playerControl;
    [SerializeField] Transform target;
    [SerializeField] float axixValue;


    private void OnTriggerEnter(Collider other)
    {
        playerControl.Activation(false, target.position, axixValue);
    }
}
