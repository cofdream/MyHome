using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HomeUI
{
    public class ArticlePanle : MonoBehaviour
    {
        public Text Text;
        public CanvasGroup CanvasGroup;

        public void Show(string content)
        {
            CanvasGroup.alpha = 1f;

            Text.text = content;
        }

        public void Hide()
        {
            CanvasGroup.alpha = 0f;
        }
    }
}
