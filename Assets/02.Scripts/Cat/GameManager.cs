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
        playTime_Txt.text = string.Format("�÷��� Ÿ�� : {0:F1}��", timer);
    }

}
