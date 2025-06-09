using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI playTime_Txt;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        //playTime_Txt.text = timer.ToString();
        playTime_Txt.text = string.Format("플레이 타임 : {0:F1}초", timer);
    }

}
