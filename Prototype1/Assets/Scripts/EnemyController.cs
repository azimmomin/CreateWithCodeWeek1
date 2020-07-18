using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
