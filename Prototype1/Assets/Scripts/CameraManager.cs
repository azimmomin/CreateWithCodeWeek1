using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private Camera[] cameras;

    private int activeCameraIndex = 0;

    void Start()
    {
        SetActiveCameraActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            SetActiveCameraActive(false);
            activeCameraIndex = (activeCameraIndex + 1) % cameras.Length;
            SetActiveCameraActive(true);
        }
    }

    private void SetActiveCameraActive(bool isActive)
    {
        cameras[activeCameraIndex].gameObject.SetActive(isActive);
    }
}
