using UnityEngine;

namespace HelixJump.Bar
{
    public class BarController : MonoBehaviour
    {
        [SerializeField] BarSettings _barSettings;
        // Rastgele üretilmesi gereken sayýlarý tutan deðiþkenler
        private int _randomObjectChange, _randomObjectFalse, _randomLoopAmount;

        // Dizi içerisinde prefab da bulunan tüm barlar bulunur
        [SerializeField] private MeshRenderer[] _bars;

        private void Start()
        {
            // 1-3 arasý rastgele bir deðer alýr
            _randomLoopAmount = Random.Range(1, 4);
            for (int i = 0; i < _randomLoopAmount; i++)
            {
                // Bu iki deðiþken 0 ile _bars dizisinin uzunluðu arasýnda bir deðer alýr
                _randomObjectChange = Random.Range(0, _bars.Length);
                _randomObjectFalse = Random.Range(0, _bars.Length);

                // Seçili elemanýn metarial'ýný ve tagýný deðiþtirir
                _bars[_randomObjectChange].material = _barSettings.BarDeadZoneMaterial;
                _bars[_randomObjectChange].gameObject.tag = "DeadZone";

                // Seçili objenin görünürlüðünü kapalý yapar
                _bars[_randomObjectFalse].gameObject.SetActive(false);
            }
        }
    }
}