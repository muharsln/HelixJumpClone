using UnityEngine;
using UnityEngine.UI;

namespace HelixJump.Score
{
    public class ScoreManager : MonoBehaviour
    {
        // ScoreCounter metodunu hafýzasýnda tutacak delegate metod
        public delegate void Score(int score);
        // Oluþturduðumuz delegate metodun objesi
        public Score ScoreIncrease;

        // Sahnede bulunan score text'imiz
        [SerializeField] private Text[] _uiText;
        // Score sayacý
        private int _scoreCounter;

        [SerializeField] private GameManager _gameManager;

        private void Awake()
        {
            // ScoreCounter'ý delegate objemizie ekliyoruz
            ScoreIncrease += ScoreCounter;
        }

        private void Start()
        {
            _uiText[1].text = PlayerPrefs.GetInt("HighScore").ToString();
        }
        private void ScoreCounter(int score)
        {
            _scoreCounter += score;
            _uiText[0].text = _scoreCounter.ToString();
        }
        private void Update()
        {
            if (_scoreCounter > PlayerPrefs.GetInt("HighScore"))
            {
                _uiText[1].text = _scoreCounter.ToString();
                PlayerPrefs.SetInt("HighScore", _scoreCounter);
                print("Girdi");
            }
        }
    }
}