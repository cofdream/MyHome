using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using HomeCore;

namespace HomeCoreEditor
{
    [CustomPropertyDrawer(typeof(SpriteAsset))]
    public class SpriteAssetEditor : PropertyDrawer
    {
        private bool isShowPath;
        private bool isBigTexture;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            //base.OnGUI(position, property, label);

            var space = 3f;
            var btnWidth = 25f;

            Rect spiteRect = position;
            spiteRect.width -= (btnWidth + space) * 2;

            Rect changeRect = position;
            changeRect.x = spiteRect.width + space;
            changeRect.width = btnWidth;

            var spriteAsset = property.boxedValue as SpriteAsset;

            if (isShowPath)
            {
                var spritePath = property.FindPropertyRelative(SpriteAsset.SpritePathFieldName).stringValue;
                var newSpritePath = EditorGUI.TextField(spiteRect, new GUIContent("Sprite Asset"), spritePath);
                if (string.Equals(spritePath, newSpritePath, System.StringComparison.OrdinalIgnoreCase) == false)
                    spriteAsset.Change(spritePath);

                if (GUI.Button(changeRect, EditorGUIUtility.IconContent("Sprite Icon")))
                {
                    isShowPath = false;
                }
            }
            else
            {
                var log = EditorGUI.PropertyField(spiteRect, property.FindPropertyRelative(SpriteAsset.SpriteFieldName), new GUIContent("Sprite Asset"));
                if (log)
                    spriteAsset.Change(spriteAsset.Sprite);

                if (GUI.Button(changeRect, EditorGUIUtility.IconContent("Text Icon")))
                {
                    isShowPath = true;
                }
            }
            if (property.serializedObject.hasModifiedProperties)
            {
                //spriteAsset.Change(spritePath);
                property.serializedObject.ApplyModifiedProperties();
            }


            Rect bigRect = changeRect;
            bigRect.x += changeRect.width + space;
            bigRect.width = btnWidth;

            if (isBigTexture)
            {
                Rect bigTextureRect = spiteRect;
                bigTextureRect.y += changeRect.height + 5f;
                bigTextureRect.width = 200f;
                bigTextureRect.height = 200f;

                GUI.DrawTexture(bigTextureRect, spriteAsset.Sprite.texture, ScaleMode.ScaleToFit);
                if (GUI.Button(bigRect, EditorGUIUtility.IconContent("winbtn_win_close")))
                {
                    isBigTexture = false;
                }
            }
            else
            {
                if (GUI.Button(bigRect, EditorGUIUtility.IconContent("Search Icon")))
                {
                    isBigTexture = true;
                }
            }

        }
    }
}
