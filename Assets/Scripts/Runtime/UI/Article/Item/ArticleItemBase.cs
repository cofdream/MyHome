using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HomeUI
{
    public class ArticleItemBase : MonoBehaviour
    {
        public Text Text;
        public Text TextContect;

        public string Title;

        [Multiline(10)]
        public string Content;


        void Start()
        {
            Text.text = Title;
            TextContect.text = Content;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
