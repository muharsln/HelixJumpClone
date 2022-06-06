using UnityEngine;

namespace HelixJump.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraSettings _cameraSettings;
        private void Start()
        {
            // camera pozisyonundan y deðerini oyun baþlayýnca cameraPos deðiþkenine ata
            _cameraSettings.CameraPosition = transform.position.y;
        }

        private void LateUpdate()
        {
            // kamera pos'unu lerp ile sadece y deðerini 0.01 yumuþak geçiþ deðeri ile deðiþ
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, _cameraSettings.CameraPosition, transform.position.z), _cameraSettings.CameraMoveSmooth);
        }
    }
}