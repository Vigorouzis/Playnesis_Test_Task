using UnityEngine;
using UnityEngine.EventSystems;

public class CubeScript : InteractiveObject
{
    private int _destroyCount = 0;

    protected override void BasicAction()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit, Mathf.Infinity))
            {
                if (hit.transform.TryGetComponent<CubeScript>(out var component) && component != null)
                {
                    _destroyCount++;
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