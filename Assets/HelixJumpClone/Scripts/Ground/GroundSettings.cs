using UnityEngine;

namespace HelixJump.Ground
{
    [CreateAssetMenu(menuName = "HelixJumpClone/Ground/GroundSettings")]
    public class GroundSettings : ScriptableObject
    {
        // Oluşturacağımız objelerin çeşitlerinin bulunduğu değişken
        [SerializeField] private GameObject _barObjectPrefab;
        public GameObject BarObjectPrefab { get { return _barObjectPrefab; } }

        // Sahnede oluşacak ground miktarını tutan değişken
        [SerializeField] private int _groundCreateCount;
        public int GroundCreateCount { get { return _groundCreateCount; } set { _groundCreateCount = value; } }

        // Ground nesnelerini oluşturacağımız y pozisyonu aralığı
        [SerializeField] private float _groundCreateDistance;
        public float GroundCreateDistance { get { return _groundCreateDistance; } }
    }
}