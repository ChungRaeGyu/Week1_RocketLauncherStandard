using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // ※ 이 내용은 변경하지 말 것 ※
    
    private Transform camT;
    [SerializeField] private Vector3 CamOffset;
    void Start()
    {
        if (Camera.main != null) camT = Camera.main.transform;
    }

    void LateUpdate()
    {
        var position = transform.position;
        position.z = -10;
        camT.position = position + CamOffset;
    }
}
