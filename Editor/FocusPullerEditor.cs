using UnityEngine;
using UnityEditor;

namespace Kino.PostProcessing.Utilities
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(FocusPuller))]
    sealed class FocusPullerEditor : Editor
    {
        SerializedProperty _camera;
        SerializedProperty _target;
        SerializedProperty _offset;

        void OnEnable()
        {
            _camera = serializedObject.FindProperty("_camera");
            _target = serializedObject.FindProperty("_target");
            _offset = serializedObject.FindProperty("_offset");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(_camera);
            EditorGUILayout.PropertyField(_target);
            EditorGUILayout.PropertyField(_offset);

            serializedObject.ApplyModifiedProperties();
        }
    }
}
