using Managers;
using TMPro;
using UnityEngine;

namespace Interactable
{
    public class DoorObject : InteractableObject
    {
        public string sceneName;
        [SerializeField] private GameObject prefabChangeSceneNotice;
        [SerializeField] private GameObject canvas;

        private Camera _camera;

        private GameObject _previewObject;
        private bool _bEnablePreview;

        private void Start()
        {
            _camera = Camera.main;
        }

        public override void Interact() {
            ScenesManager.instance.LoadScene(sceneName);
        }

        public override void Preview()
        {
            var objectPositionInCamera = _camera.WorldToScreenPoint(transform.position);
            _previewObject = Instantiate(prefabChangeSceneNotice, objectPositionInCamera, Quaternion.identity, canvas.transform);
            _previewObject.GetComponent<TextMeshProUGUI>().text = "Press E for\ngo to " + sceneName;
            
            _bEnablePreview = true;
        }

        public override void RemovePreview()
        {
            _bEnablePreview = false;
            Destroy(_previewObject);
        }

        private void FixedUpdate()
        {
            if (!_bEnablePreview) return;
            
            _previewObject.transform.position = _camera.WorldToScreenPoint(transform.position);
        }
    }
}
