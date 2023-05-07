using HomeData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HomeUI
{
    public class Main : MonoBehaviour
    {
        public UserData UserData;

        public TitleBar TitleBar;
        public ContentUI Content;

        private void Awake()
        {
            TitleBar.UserData = UserData;
            Content.UserData = UserData;
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
