using UnityEngine;

namespace HelixJump.Ground
{
    [CreateAssetMenu(menuName = "HelixJumpClone/Ground/GroundSettings")]
    public class GroundSettings : ScriptableObject
    {
        // Oluþturacaðýmýz objelerin çeþitlerinin bulunduðu deðiþken
        [SerializeField] private GameObject _barObjectPrefab;
        public GameObject BarObjectPrefab { get { return _barObjectPrefab; } }

        // Sahnede oluþacak ground miktarýný tutan deðiþken
        [SerializeField] private int _groundCreateCount;
        public int GroundCreateCount { get { return _groundCreateCount; } set { _groundCreateCount = value; } }

        // Ground nesnelerini oluþturacaðýmýz y pozisyonu aralýðý
        [SerializeField] private float _groundCreateDistance;
        public float GroundCreateDistance { get { return _groundCreateDistance; } }
    }
}