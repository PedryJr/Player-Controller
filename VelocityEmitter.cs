using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(Animator))]
public class VelocityEmitter : MonoBehaviour
{

    Rigidbody rb;
    Animator anim;

    [SerializeField] string velocityParameter;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {

        anim.SetFloat(velocityParameter, rb.linearVelocity.magnitude);

    }

}
