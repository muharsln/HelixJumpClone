using System.Collections.Generic;
using UnityEngine;

namespace HelixJump.SplashPaint
{
    public class SplashPaintCreator : MonoBehaviour
    {
        // Paintlerden olu�an dizi
        public List<GameObject> paintObjects;

        // Olu�an paintlerin parent objeleri
        public Transform paintParent;

        // Paint prefab�n� haf�zas�nda tutan de�i�en
        [SerializeField] private GameObject _paintPrefab;

        private int _randomRotation;

        private void Start()
        {
            for (int i = 0; i < 20; i++)
            {
                _randomRotation = Random.Range(0, 360);
                paintObjects.Add(Instantiate(_paintPrefab));
                paintObjects[i].SetActive(false);
                paintObjects[i].transform.position = paintParent.position;
                paintObjects[i].transform.rotation = Quaternion.Euler(90, _randomRotation, 0);
                paintObjects[i].transform.parent = paintParent;
            }
        }
    }
}