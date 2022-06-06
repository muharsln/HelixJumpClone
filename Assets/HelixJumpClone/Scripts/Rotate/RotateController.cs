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
                // Mouse'un sol du�una bas�nca bu de�i�kene mevcut mouse pozisyonunu ata
                if (Input.GetMouseButtonDown(0)) _firstInputPosition = Input.mousePosition;

                // Mouse'un sol tu�una bas�l� tuttu�umuz s�re boyunca lastInputu mevcut mouse pos yap
                if (Input.GetMouseButton(0)) _lastInputPosition = Input.mousePosition;

                // rotasyon a��s�na son pozisyonumuzdan ilk pozisyonumuzu ��kar�p ata
                _rotAngles = _lastInputPosition - _firstInputPosition;

                // rotate edece�imiz objenin belirtti�imiz a��da y rotasyonunu de�i�
                _rotateObject.transform.rotation = Quaternion.Euler(0, _rotAngles.x * _rotateSpeed, 0);
            }
        }
    }
}