using TMPro;
using UnityEngine;


public class NumberKeyPad : MonoBehaviour
{
    public TextMeshProUGUI pw_txt; 
    
    public string password;
    public string keyPadNumber;

    public Animator doorAnim;

    private void OnEnable()
    {
        keyPadNumber = "";
        pw_txt.text = "";
    }

    public void OnInputNumber(string num)
    {
        pw_txt.text += num;
        keyPadNumber += num;
    }
    
    public void OnCheckNumber()
    {
        if (keyPadNumber == password)
        {
            this.gameObject.SetActive(false);
            doorAnim.SetTrigger("Open");
            Debug.Log("문 열림");
        }
        else
        {
            keyPadNumber = "";
            pw_txt.text = "";
            Debug.Log("비밀 번호 오류");
        }
    }

    public void BackSpaceNumber()
    {
        if (pw_txt.text.Length < 1)
            return;
        else
        {
            keyPadNumber = keyPadNumber.Substring(0, keyPadNumber.Length - 1);
            pw_txt.text = pw_txt.text.Substring(0, pw_txt.text.Length - 1);
        }
    }
}
