using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI playTime_Txt;
    public TextMeshProUGUI score_Txt;

    private float timer;
    public static int score;
    public static bool isPlay = false;

    private void Update()
    {
        if (!isPlay) return;

        timer += Time.deltaTime;
        //playTime_Txt.text = timer.ToString();
        playTime_Txt.text = string.Format("�÷��� Ÿ�� : {0:F1}��", timer);
        //score_Txt.text = $"<color=red>X</color>{score}";
        score_Txt.text = $"X {score}";
    }

}
