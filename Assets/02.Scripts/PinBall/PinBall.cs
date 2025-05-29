using UnityEngine;

public class PinBall : MonoBehaviour
{
    public PinBallManager pinballManager;


    private void OnCollisionEnter2D(Collision2D col)
    {
        int score = 0;
        switch(col.gameObject.tag)
        {
            case "Score10":
                score = 10;
                ChangeColor(col.gameObject);
                break;
            case "Score30":
                score = 30;
                ChangeColor(col.gameObject);
                break;
            case "Score50":
                score = 50;
                ChangeColor(col.gameObject);
                break;
            default :
                break;
        }
        pinballManager.totalScore += score;
        Debug.Log($"{score}점 획득!");

        //if (col.gameObject.CompareTag("Score10"))
        //{
        //    pinballManager.totalScore += 10;
        //    Debug.Log("10 Score");
        //}
        //if (col.gameObject.CompareTag("Score30"))
        //{
        //    pinballManager.totalScore += 30;
        //    Debug.Log("30 Score");
        //}
        //if (col.gameObject.CompareTag("Score50"))
        //{
        //    pinballManager.totalScore += 50;
        //    Debug.Log("50 Score");
        //}
    }
    public void ChangeColor(GameObject go)
    {
        float r = Random.Range(0f, 255f);
        float g = Random.Range(0f, 255f);
        float b = Random.Range(0f, 255f);
    
        go.GetComponent<SpriteRenderer>().color = new Color(r/255, g/255, b/255);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("GameOver"))
        {
            Debug.Log($"게임 종료 : 현재 점수 {pinballManager.totalScore}");
            Debug.Log("Game Over");
        }
    }
}
