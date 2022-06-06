using UnityEngine;

namespace HelixJump.Bar
{
    public class BarController : MonoBehaviour
    {
        [SerializeField] BarSettings _barSettings;
        // Rastgele �retilmesi gereken say�lar� tutan de�i�kenler
        private int _randomObjectChange, _randomObjectFalse, _randomLoopAmount;

        // Dizi i�erisinde prefab da bulunan t�m barlar bulunur
        [SerializeField] private MeshRenderer[] _bars;

        private void Start()
        {
            // 1-3 aras� rastgele bir de�er al�r
            _randomLoopAmount = Random.Range(1, 4);
            for (int i = 0; i < _randomLoopAmount; i++)
            {
                // Bu iki de�i�ken 0 ile _bars dizisinin uzunlu�u aras�nda bir de�er al�r
                _randomObjectChange = Random.Range(0, _bars.Length);
                _randomObjectFalse = Random.Range(0, _bars.Length);

                // Se�ili eleman�n metarial'�n� ve tag�n� de�i�tirir
                _bars[_randomObjectChange].material = _barSettings.BarDeadZoneMaterial;
                _bars[_randomObjectChange].gameObject.tag = "DeadZone";

                // Se�ili objenin g�r�n�rl���n� kapal� yapar
                _bars[_randomObjectFalse].gameObject.SetActive(false);
            }
        }
    }
}