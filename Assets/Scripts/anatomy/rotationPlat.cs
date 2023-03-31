using UnityEngine;

namespace anatomy.levelone
{
    public class rotationPlat: MonoBehaviour
    {
            [SerializeField]
            private anatomySettings _settings;

            [SerializeField]
            private Vector3 _localAxis = Vector3.up;

            #region Properties

            public Vector3 LocalAxis
            {
                get => _localAxis;
                set => _localAxis = value;
            }

            #endregion

            protected virtual void Update()
            {
                transform.Rotate(_localAxis, _settings.rotSpeed * Time.deltaTime, Space.Self);
            }
        
    }
}
