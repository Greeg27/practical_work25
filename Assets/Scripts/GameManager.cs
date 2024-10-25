using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerControl playerControl;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void StartPlayerControl()
    {
        playerControl.Activation(true);
    }
}
