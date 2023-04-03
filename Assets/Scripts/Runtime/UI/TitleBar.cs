using HomeData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HomeUI
{
    public class TitleBar : MonoBehaviour
    {
        public UserData UserData;

        public Image HeadImage;
        public Text TitleText;
        public Text SubtitleText;

        // Start is called before the first frame update
        void Start()
        {
            RefreshData(UserData);
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void RefreshData(UserData userData)
        {
            HeadImage.sprite = UserData.UserHeadIcon.Sprite;
            TitleText.text = userData.Title;
            SubtitleText.text = userData.Subtitle;
        }
    }
}
