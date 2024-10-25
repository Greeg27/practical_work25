using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform playerTarget;

    private Rigidbody _rigidbody;
    private Animator _animator;
    private Vector3 _playerTarget;
    private float _vertical;
    private bool _activ;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        InputAxis();
    }

    private void FixedUpdate()
    {
        SetPlayerTarget();
        Turn();
        Movement();
        Animation();
    }

    public void Activation(bool Activ, Vector3 PlayerTarget, float AxixValue)
    {
        _activ = Activ;
        _vertical = AxixValue;
        _playerTarget = PlayerTarget;
    }

    public void Activation(bool Activ)
    {
        _activ = Activ;
    }

    private void InputAxis()
    {
        if (_activ)
        {
            _vertical = Input.GetAxis("Vertical");
        }
    }

    private void SetPlayerTarget()
    {
        if (_activ)
        {
            _playerTarget = playerTarget.position;
        }
    }

    private void Movement()
    {
        _rigidbody.velocity = new Vector3(_playerTarget.x - transform.position.x, 0,
                _playerTarget.z - transform.position.z).normalized * _vertical * speed;
    }

    private void Turn()
    {
        if (_vertical > 0.1)
        {
            transform.LookAt(new Vector3(_playerTarget.x, transform.position.y, _playerTarget.z));
        }
    }

    private void Animation()
    {
        _animator.SetFloat("RunFloat", _vertical);
    }
}
