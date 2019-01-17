using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace Kino.PostProcessing.Utilities
{
    [ExecuteInEditMode]
    public sealed class FocusPuller : MonoBehaviour
    {
        [SerializeField] Camera _camera = null;
        [SerializeField] Transform _target = null;
        [SerializeField] float _offset = 0;

        DepthOfField _dof;
        PostProcessProfile _profile;
        PostProcessVolume _volume;

        void Start()
        {
            _dof = ScriptableObject.CreateInstance<DepthOfField>();
            _dof.hideFlags = HideFlags.DontSave;
            _dof.focusDistance.overrideState = true;
            _dof.enabled.value = true;

            _profile = ScriptableObject.CreateInstance<PostProcessProfile>();
            _profile.hideFlags = HideFlags.DontSave;
            _profile.AddSettings(_dof);

            _volume = gameObject.AddComponent<PostProcessVolume>();
            _volume.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
            _volume.sharedProfile = _profile;
            _volume.isGlobal = true;
            _volume.priority = 1000;

            LateUpdate();
        }

        void OnDestroy()
        {
            DestroyAsset(_dof);
            DestroyAsset(_profile);
        }

        void LateUpdate()
        {
            if (_camera == null || _target == null) return;

            _dof.focusDistance.value =
                (_camera.transform.position - _target.position).magnitude + _offset;
        }

        static void DestroyAsset(Object o)
        {
            if (o == null) return;
            if (Application.isPlaying)
                Object.Destroy(o);
            else
                Object.DestroyImmediate(o);
        }
    }
}
