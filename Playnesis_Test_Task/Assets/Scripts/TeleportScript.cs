using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportScript : InteractiveObject
{
    [SerializeField] private GameObject _sendObject;

    protected override void BasicAction()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit, Mathf.Infinity))
            {
                if (hit.transform.TryGetComponent<TeleportScript>(out var component) && component != null)
                {
                    var sceneToLoad = SceneManager.GetSceneByName("");
                    SceneManager.LoadScene("Scenes/Scene2");
                    SceneManager.MoveGameObjectToScene(_sendObject.gameObject, sceneToLoad);
                }
            }
        }
    }
}