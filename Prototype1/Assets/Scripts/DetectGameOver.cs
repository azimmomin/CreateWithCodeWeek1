using UnityEngine;

public class DetectGameOver : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.LogError($"{collision.gameObject.name} Won!");
    }
}
