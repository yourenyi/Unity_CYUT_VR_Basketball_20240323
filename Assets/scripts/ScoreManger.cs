using TMPro;
using UnityEngine;

public class ScoreManger : MonoBehaviour
{
    [SerializeField, Header("分數文字")]
    private TMP_Text testScore;
    private string basketballName = "籃球";
    private int score;
        private void OnTriggerEnter(Collider other)
    {
        // print(other.name);
        if (other.name.Contains(basketballName))
        {
            score += 2;
            // print($"<color=#f93>分數:{score}</color>");
            testScore.text = $"score - {score}";
        }

    }
}
