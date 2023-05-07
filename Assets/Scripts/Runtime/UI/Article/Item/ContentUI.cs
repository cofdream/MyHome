using HomeData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HomeUI
{
    public class ContentUI : MonoBehaviour
    {
        public UserData UserData;

        public ArticleItemBase Item;

        public int Count = 5;

        void Start()
        {
            for (int i = 0; i < Count; i++)
            {
                var item = GameObject.Instantiate<ArticleItemBase>(Item, transform);
            }
           
        }


        void Update()
        {

        }
    }
}
