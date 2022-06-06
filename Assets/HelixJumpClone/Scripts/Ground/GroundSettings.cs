using UnityEngine;

namespace HelixJump.Ground
{
    [CreateAssetMenu(menuName = "HelixJumpClone/Ground/GroundSettings")]
    public class GroundSettings : ScriptableObject
    {
        // Olu�turaca��m�z objelerin �e�itlerinin bulundu�u de�i�ken
        [SerializeField] private GameObject _barObjectPrefab;
        public GameObject BarObjectPrefab { get { return _barObjectPrefab; } }

        // Sahnede olu�acak ground miktar�n� tutan de�i�ken
        [SerializeField] private int _groundCreateCount;
        public int GroundCreateCount { get { return _groundCreateCount; } set { _groundCreateCount = value; } }

        // Ground nesnelerini olu�turaca��m�z y pozisyonu aral���
        [SerializeField] private float _groundCreateDistance;
        public float GroundCreateDistance { get { return _groundCreateDistance; } }
    }
}