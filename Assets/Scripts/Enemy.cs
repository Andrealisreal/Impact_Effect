using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particles;
    
    private static readonly int Hit = Animator.StringToHash("Hit");
    
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Attack attack))
        {
            _animator.SetTrigger(Hit);
            var p = Instantiate(_particles, transform.position, transform.rotation);
            p.Play();
        }
    }
}
