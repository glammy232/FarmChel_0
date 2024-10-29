using UnityEngine;

public class Raiting : MonoBehaviour
{
    public RaitingTemplate _template;

    public Transform _parent;

    private void OnEnable()
    {

        if (_parent.childCount > 0)
            Destroy(_parent.GetChild(0).gameObject);

        if (_parent.childCount > 0)
            Destroy(_parent.GetChild(0).gameObject);

        if (_parent.childCount > 0)
            Destroy(_parent.GetChild(0).gameObject);

        if (Variables.Record0 > 0)
        {
            var temp = Instantiate(_template, _parent);

            temp.Initialize("Record 1", Variables.Record0.ToString());
        }

        if (Variables.Record1 > 0)
        {
            var temp = Instantiate(_template, _parent);

            temp.Initialize("Record 2", Variables.Record1.ToString());
        }

        if (Variables.Record2 > 0)
        {
            var temp = Instantiate(_template, _parent);

            temp.Initialize("Record 3", Variables.Record2.ToString());
        }
    }
}
