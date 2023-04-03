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
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            //base.OnGUI(position, property, label);
            Rect spiteRect = position;
            spiteRect.width = 100f;
            spiteRect.height = 100f;

            var aa = property.serializedObject.context;

            var spiteSP = property.FindPropertyRelative("Sprite");

            //GUI.DrawTexture(spiteRect, ((Sprite)spiteSP.serializedObject.context)?.texture);

            EditorGUI.PropertyField(spiteRect, property.FindPropertyRelative("Sprite"), GUIContent.none);
        }
    }
}
