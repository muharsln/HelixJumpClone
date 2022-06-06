using UnityEngine;

namespace HelixJump.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraSettings _cameraSettings;
        private void Start()
        {
            // camera pozisyonundan y de�erini oyun ba�lay�nca cameraPos de�i�kenine ata
            _cameraSettings.CameraPosition = transform.position.y;
        }

        private void LateUpdate()
        {
            // kamera pos'unu lerp ile sadece y de�erini 0.01 yumu�ak ge�i� de�eri ile de�i�
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, _cameraSettings.CameraPosition, transform.position.z), _cameraSettings.CameraMoveSmooth);
        }
    }
}