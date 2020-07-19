using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private float turnSpeed = 45f;
    [SerializeField] private string horizontalInputAxisName = string.Empty;
    [SerializeField] private string veritcalInputAxisName = string.Empty;

    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis(horizontalInputAxisName);
        verticalInput = Input.GetAxis(veritcalInputAxisName);

        transform.Translate(Vector3.forward * (Time.deltaTime * speed * verticalInput));
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
