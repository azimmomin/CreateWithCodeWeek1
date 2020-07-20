using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player = null;
    [SerializeField] private bool followPlayerRotation = false;

    private Vector3 offset = Vector3.zero;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        if (followPlayerRotation)
            transform.rotation = player.transform.rotation;
    }
}
