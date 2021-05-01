using ScriptableValues;
using UnityEngine;
using UnityEngine.EventSystems;

public class DamageCapsuleScript : InteractiveObject
{
    [SerializeField] private QuantitiesForChanges _quantities;

    protected override void BasicAction()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit, Mathf.Infinity))
            {
                Debug.DrawRay(_camera.transform.position, hit.transform.position, Color.yellow);

                if (hit.transform.TryGetComponent<DamageCapsuleScript>(out var component) && component != null)
                {
                    _playerIndicators.health -= _quantities.damage;
                }
            }
        }
    }
}