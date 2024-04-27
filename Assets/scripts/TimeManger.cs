using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeManger : MonoBehaviour
{
    [SerializeField, Header("��r�ɶ�")]
    private TMP_Text textTime;
    [SerializeField, Header("�˼Ʈɶ�"), Range(10, 180)]
    private float timeTotal = 60;
    [SerializeField, Header("�e���C������")]
    private GameObject canvasFishlObject;
    [SerializeField, Header("�ˬd���ƺ޲z��")]
    private GameObject scoreMangerObject;
    [SerializeField, Header("���s�ͦ��x�y")]
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
