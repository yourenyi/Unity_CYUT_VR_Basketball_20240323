using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeManger : MonoBehaviour
{
    [SerializeField, Header("文字時間")]
    private TMP_Text textTime;
    [SerializeField, Header("倒數時間"), Range(10, 180)]
    private float timeTotal = 60;
    [SerializeField, Header("畫布遊戲結束")]
    private GameObject canvasFishlObject;
    [SerializeField, Header("檢查分數管理器")]
    private GameObject scoreMangerObject;
    [SerializeField, Header("按鈕生成籃球")]
    private Button btnSpawn;
    private void Update()
    {
        CountDown();
    }

    private void CountDown()
    {
        timeTotal -= Time.deltaTime;

        timeTotal = timeTotal = Mathf.Clamp(timeTotal, 0, 180);

        textTime.text = $"TIME - {timeTotal.ToString("F0")}";

        if (timeTotal == 0) GameOver();
    }

    private void GameOver()
    {
        canvasFishlObject.SetActive(true);
        scoreMangerObject.SetActive(false);
        btnSpawn.interactable = false;
    }
}
