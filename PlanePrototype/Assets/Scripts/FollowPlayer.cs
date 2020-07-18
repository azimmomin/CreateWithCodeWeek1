using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject playerToFollow;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - playerToFollow.transform.position;
    }

    void Update()   
    {
        transform.position = playerToFollow.transform.position + offset;
    }
}
