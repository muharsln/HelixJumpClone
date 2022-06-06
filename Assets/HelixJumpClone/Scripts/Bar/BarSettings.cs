using UnityEngine;

namespace HelixJump.Bar
{
    [CreateAssetMenu(menuName = "HelixJumpClone/Bar/BarSettings")]
    public class BarSettings : ScriptableObject
    {
        // �l�m b�lgesi rengi;
        [SerializeField] private Material _barDeadZoneMaterial;

        public Material BarDeadZoneMaterial => _barDeadZoneMaterial;
    }
}