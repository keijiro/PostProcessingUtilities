// Utility scripts for the post processing stack
// https://github.com/keijiro/PostProcessingUtilities

using UnityEngine;
using UnityEditor;

namespace UnityEngine.PostProcessing.Utilities
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(PostProcessingController))]
    public class PostProcessingControllerEditor : Editor
    {
        #region Public structs

        SerializedProperty _enableAntialiasing;
        SerializedProperty _antialiasing;

        SerializedProperty _enableAmbientOcclusion;
        SerializedProperty _ambientOcclusion;

        SerializedProperty _enableScreenSpaceReflection;
        SerializedProperty _screenSpaceReflection;

        SerializedProperty _enableDepthOfField;
        SerializedProperty _depthOfField;

        SerializedProperty _enableMotionBlur;
        SerializedProperty _motionBlur;

        SerializedProperty _enableEyeAdaptation;
        SerializedProperty _eyeAdaptation;

        SerializedProperty _enableBloom;
        SerializedProperty _bloom;

        SerializedProperty _enableColorGrading;
        SerializedProperty _colorGrading;

        SerializedProperty _enableUserLut;
        SerializedProperty _userLut;

        SerializedProperty _enableChromaticAberration;
        SerializedProperty _chromaticAberration;

        SerializedProperty _enableGrain;
        SerializedProperty _grain;

        SerializedProperty _enableVignette;
        SerializedProperty _vignette;

        #endregion

        #region Text labels

        static GUIContent _textEnabled = new GUIContent("Enabled");
        static GUIContent _textAttributes = new GUIContent("Attributes");

        #endregion

        #region Editor functions

        void OnEnable()
        {
            _enableAntialiasing = serializedObject.FindProperty("enableAntialiasing");
            _antialiasing = serializedObject.FindProperty("antialiasing");

            _enableAmbientOcclusion = serializedObject.FindProperty("enableAmbientOcclusion");
            _ambientOcclusion = serializedObject.FindProperty("ambientOcclusion");

            _enableScreenSpaceReflection = serializedObject.FindProperty("enableScreenSpaceReflection");
            _screenSpaceReflection = serializedObject.FindProperty("screenSpaceReflection");

            _enableDepthOfField = serializedObject.FindProperty("enableDepthOfField");
            _depthOfField = serializedObject.FindProperty("depthOfField");

            _enableMotionBlur = serializedObject.FindProperty("enableMotionBlur");
            _motionBlur = serializedObject.FindProperty("motionBlur");

            _enableEyeAdaptation = serializedObject.FindProperty("enableEyeAdaptation");
            _eyeAdaptation = serializedObject.FindProperty("eyeAdaptation");

            _enableBloom = serializedObject.FindProperty("enableBloom");
            _bloom = serializedObject.FindProperty("bloom");

            _enableColorGrading = serializedObject.FindProperty("enableColorGrading");
            _colorGrading = serializedObject.FindProperty("colorGrading");

            _enableUserLut = serializedObject.FindProperty("enableUserLut");
            _userLut = serializedObject.FindProperty("userLut");

            _enableChromaticAberration = serializedObject.FindProperty("enableChromaticAberration");
            _chromaticAberration = serializedObject.FindProperty("chromaticAberration");

            _enableGrain = serializedObject.FindProperty("enableGrain");
            _grain = serializedObject.FindProperty("grain");

            _enableVignette = serializedObject.FindProperty("enableVignette");
            _vignette = serializedObject.FindProperty("vignette");
        }

        public override void OnInspectorGUI()
        {
            if (!Application.isPlaying)
            {
                EditorGUILayout.HelpBox("The properties are only shown while playing.", MessageType.None);
                return;
            }

            serializedObject.Update();

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Antialiasing", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(_enableAntialiasing, _textEnabled);
            if (_enableAntialiasing.boolValue)
                EditorGUILayout.PropertyField(_antialiasing, _textAttributes, true);

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Ambient Occlusion", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(_enableAmbientOcclusion, _textEnabled);
            if (_enableAmbientOcclusion.boolValue)
                EditorGUILayout.PropertyField(_ambientOcclusion, _textAttributes, true);

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Screen Space Reflection", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(_enableScreenSpaceReflection, _textEnabled);
            if (_enableScreenSpaceReflection.boolValue)
                EditorGUILayout.PropertyField(_screenSpaceReflection, _textAttributes, true);

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Depth Of Field", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(_enableDepthOfField, _textEnabled);
            if (_enableDepthOfField.boolValue)
                EditorGUILayout.PropertyField(_depthOfField, _textAttributes, true);

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Motion Blur", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(_enableMotionBlur, _textEnabled);
            if (_enableMotionBlur.boolValue)
                EditorGUILayout.PropertyField(_motionBlur, _textAttributes, true);

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Eye Adaptation", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(_enableEyeAdaptation, _textEnabled);
            if (_enableEyeAdaptation.boolValue)
                EditorGUILayout.PropertyField(_eyeAdaptation, _textAttributes, true);

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Bloom", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(_enableBloom, _textEnabled);
            if (_enableBloom.boolValue)
                EditorGUILayout.PropertyField(_bloom, _textAttributes, true);

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Color Grading", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(_enableColorGrading, _textEnabled);
            if (_enableColorGrading.boolValue)
                EditorGUILayout.PropertyField(_colorGrading, _textAttributes, true);

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("User Lut", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(_enableUserLut, _textEnabled);
            if (_enableUserLut.boolValue)
                EditorGUILayout.PropertyField(_userLut, _textAttributes, true);

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Chromatic Aberration", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(_enableChromaticAberration, _textEnabled);
            if (_enableChromaticAberration.boolValue)
                EditorGUILayout.PropertyField(_chromaticAberration, _textAttributes, true);

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Grain", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(_enableGrain, _textEnabled);
            if (_enableGrain.boolValue)
                EditorGUILayout.PropertyField(_grain, _textAttributes, true);

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Vignette", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(_enableVignette, _textEnabled);
            if (_enableVignette.boolValue)
                EditorGUILayout.PropertyField(_vignette, _textAttributes, true);

            serializedObject.ApplyModifiedProperties();
        }

        #endregion
    }
}
