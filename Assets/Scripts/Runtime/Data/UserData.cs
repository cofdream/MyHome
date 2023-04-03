using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HomeCore;

namespace Home.Data
{
    public class UserData : ScriptableObject
    {
        public string UserName;
        public string Title;
        public string Subtitle;
        public SpriteAsset Sprite;
    }
}