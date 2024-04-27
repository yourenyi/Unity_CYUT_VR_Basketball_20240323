using TMPro;
using UnityEngine;

public class TimeManger : MonoBehaviour
{
    [SerializeField, Header("文字時間")]
    private TMP_Text textTime;
    [SerializeField, Header("倒數時間"), Range(10, 180)]
    private float timeTotal = 60;

    private void Update()
    {
        CountDown();
    }

    private void CountDown()
    {
        timeTotal -= Time.deltaTime;

        timeTotal = timeTotal = Mathf.Clamp(timeTotal, 0, 180);

        textTime.text = $"TIME - {timeTotal.ToString("F0")}";

    }

}
