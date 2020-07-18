using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float rotationSpeed = 100f;
    /// <summary>
    /// If true, plane will move upwards on up input,
    /// and downward on down input. If false, the
    /// movement will be reversed.
    /// </summary>
    [SerializeField] private bool useNaturalMotion = true;
    private float verticalInput = 0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        float direction = useNaturalMotion ? -1.0f : 1.0f;

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * (rotationSpeed * Time.deltaTime * verticalInput * direction));
    }
}
