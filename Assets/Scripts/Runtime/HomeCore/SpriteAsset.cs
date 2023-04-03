using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HomeCore
{
    [System.Serializable]
    public class SpriteAsset
    {
#if UNITY_EDITOR
        public static readonly string SpritePathFieldName = nameof(_spritePath);
        public static readonly string SpriteFieldName = nameof(_sprite);
#endif
        [SerializeField]
        private string _spritePath;
        public string SpritePath => _spritePath;

        [SerializeField]
        private Sprite _sprite;
        public Sprite Sprite => _sprite;


#if UNITY_EDITOR
        public void Change(string spritePath)
        {
            var sprite = UnityEditor.AssetDatabase.LoadAssetAtPath<Sprite>($"Assets/Resources/{spritePath}");
            if (sprite != null)
            {
                _spritePath = spritePath;
                _sprite = sprite;
            }
        }
        public void Change(Sprite sprite)
        {
            if (sprite == null)
            {
                return;
            }
            var path = UnityEditor.AssetDatabase.GetAssetPath(sprite);
            if (path != null)
            {
                var root = "Assets/Resources/";
                _spritePath = path.Substring(root.Length, path.Length - root.Length);
                _sprite = sprite;
            }
        } 
#endif
    }
}
