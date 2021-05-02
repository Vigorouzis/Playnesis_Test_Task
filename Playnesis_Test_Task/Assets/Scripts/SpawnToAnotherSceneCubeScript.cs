using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnToAnotherSceneCubeScript : InteractiveObject
{
    [SerializeField] private GameObject _sendObject;

    protected override void BasicAction()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit, Mathf.Infinity))
            {
                if (hit.transform.TryGetComponent<SpawnToAnotherSceneCubeScript>(out var component) &&
                    component != null)
                {
                    StartCoroutine(Spawn());
                }
            }
        }
    }

    IEnumerator Spawn()
    {
        SceneManager.LoadScene("Scene2", LoadSceneMode.Additive);
        Scene nextScene = SceneManager.GetSceneByName("Scene2");

        SceneManager.MoveGameObjectToScene(_sendObject.gameObject, nextScene);
        yield return null;
        SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("SampleScene"));
    }
}