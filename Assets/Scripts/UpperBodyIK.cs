using UnityEngine;
using RootMotion.FinalIK;

public class UpperBodyIK : MonoBehaviour
{
    #region Variables

    [Header("Final IK Modules")]
    [SerializeField] private LookAtIK m_headLookAtIK = default;
    [SerializeField] private LookAtIK m_bodyLookAtIK = default;

    #endregion

    #region BuiltIn Methods

    private void Start()
    {
        m_headLookAtIK.enabled = false;
        m_bodyLookAtIK.enabled = false;
    }

    private void Update()
    {
        m_bodyLookAtIK.solver.FixTransforms();
        m_headLookAtIK.solver.FixTransforms();
    }

    private void LateUpdate()
    {
        LookAtIKUpdate();
    }

    #endregion

    #region Custom Methods

    private void LookAtIKUpdate()
    {
        m_bodyLookAtIK.solver.Update();
        m_headLookAtIK.solver.Update();
    }

    #endregion
}
