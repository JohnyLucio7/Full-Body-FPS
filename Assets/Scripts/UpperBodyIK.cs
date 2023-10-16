using UnityEngine;
using RootMotion.FinalIK;

public class UpperBodyIK : MonoBehaviour
{
    #region Variables

    [Header("Final IK Modules")]
    [SerializeField] private LookAtIK m_headLookAtIK = default;
    [SerializeField] private LookAtIK m_bodyLookAtIK = default;
    [SerializeField] private ArmIK m_leftAimIK = default;
    [SerializeField] private ArmIK m_rightAimIK = default;
    [SerializeField] private FullBodyBipedIK m_fbbIK = default;

    [Header("LookAt Settings")]
    [SerializeField] Transform m_camera = default;
    [SerializeField] Transform m_headTarget = default;

    [Header("Head Effector Settings")]
    [SerializeField] Transform m_headEffector = default;

    #endregion

    #region BuiltIn Methods

    private void Start()
    {
        m_headLookAtIK.enabled = false;
        m_bodyLookAtIK.enabled = false;
        m_leftAimIK.enabled = false;
        m_rightAimIK.enabled = false;
        m_fbbIK.enabled = false;
    }

    private void Update()
    {
        m_bodyLookAtIK.solver.FixTransforms();
        m_headLookAtIK.solver.FixTransforms();
        m_fbbIK.solver.FixTransforms();
        m_rightAimIK.solver.FixTransforms();
        m_leftAimIK.solver.FixTransforms();
    }

    private void LateUpdate()
    {
        LookAtIKUpdate();
        FBBIKUpdate();
        ArmsIKUpdate();
    }

    #endregion

    #region Custom Methods

    private void LookAtIKUpdate()
    {
        m_bodyLookAtIK.solver.Update();
        m_headLookAtIK.solver.Update();
    }

    private void ArmsIKUpdate()
    {
        m_rightAimIK.solver.Update();
        m_rightAimIK.solver.Update();
    }

    private void FBBIKUpdate()
    {
        m_fbbIK.solver.Update();

        m_camera.LookAt(m_headTarget);
        m_headEffector.LookAt(m_headTarget);
    }


    #endregion
}
