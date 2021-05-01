using UnityEngine;
using UnityEngine.EventSystems;

public class CubeScript : InteractiveObject
{
    private int _destroyCount = 0;
    [SerializeField] private LayerMask _layer;

    protected override void BasicAction()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit, Mathf.Infinity))
            {
                if (hit.transform.name == "CubeForDelete")
                {
                    _destroyCount++;
                    Debug.Log(_destroyCount);
                    if (_destroyCount == 3)
                    {
                        Destroy(hit.transform.gameObject);
                        _destroyCount = 0;
                    }
                }
            }
        }
    }
}