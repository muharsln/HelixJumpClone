using UnityEngine;

namespace HelixJump.Rotate
{
    public class RotateController : MonoBehaviour
    {
        [SerializeField] private GameManager _gameManager;
        [SerializeField] private GameObject _rotateObject;
        [SerializeField] private float _rotateSpeed;

        private Vector3 _rotAngles, _firstInputPosition, _lastInputPosition;

        private void Update()
        {
            if (_gameManager.state == GameManager.GameState.Play)
            {
                // Mouse'un sol duþuna basýnca bu deðiþkene mevcut mouse pozisyonunu ata
                if (Input.GetMouseButtonDown(0)) _firstInputPosition = Input.mousePosition;

                // Mouse'un sol tuþuna basýlý tuttuðumuz süre boyunca lastInputu mevcut mouse pos yap
                if (Input.GetMouseButton(0)) _lastInputPosition = Input.mousePosition;

                // rotasyon açýsýna son pozisyonumuzdan ilk pozisyonumuzu çýkarýp ata
                _rotAngles = _lastInputPosition - _firstInputPosition;

                // rotate edeceðimiz objenin belirttiðimiz açýda y rotasyonunu deðiþ
                _rotateObject.transform.rotation = Quaternion.Euler(0, _rotAngles.x * _rotateSpeed, 0);
            }
        }
    }
}