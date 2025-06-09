using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cat
{
    public class UIManager : MonoBehaviour
    {
        public GameObject intro;
        public GameObject inGame;

        public TMP_InputField catName_InputField;
        public TextMeshProUGUI cat_Name;

        public Button play_Btn;


        private void Start()
        {
            play_Btn.onClick.AddListener(OnClickPlayBtn);
        }

        public void OnClickPlayBtn()
        {

            if (catName_InputField.text =="")
            {
                return;
            }
            else
            {
                intro.SetActive(false);
                inGame.SetActive(true);
                cat_Name.text = catName_InputField.text;
            }
        }

    }
}