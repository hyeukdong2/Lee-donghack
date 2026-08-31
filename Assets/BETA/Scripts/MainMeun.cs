using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BETA7
{
    public class MainMeun : MonoBehaviour
    {
        public GameObject MenuBack;
        public GameObject Setting;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void BtnStert()
        {

            SceneManager.LoadScene("SampleScene");
        }

        public void BtnSetting()
        {
            MenuBack.GetComponent<Animator>().SetTrigger("Close");
        }
        public void BtnExit()
        {
            Application.Quit();
        }

        void OpenSetting()
        {
            Setting.SetActive(true);
            Setting.GetComponent<Animator>().SetTrigger("Open");
        }
    }
}
