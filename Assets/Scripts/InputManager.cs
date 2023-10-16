using UnityEngine;

public class InputManager : MonoBehaviour
{

    #region Variables

    [Header("Movement Axis")]
    [SerializeField] private string m_forwardsAxis = "Vertical";
    [SerializeField] private string m_sidewayAxis = "Horizontal";

    protected float m_forward;
    protected float m_sideway;

    #endregion

    #region Unity Methods

    private void Update()
    {
        HandleInput();
    }

    #endregion

    #region Properties

    public float Forward
    {
        get { return m_forward; }
    }

    public float Sideway
    {
        get { return m_sideway; }
    }

    #endregion

    #region Custom Methods

    protected void HandleInput()
    {
        m_forward = Input.GetAxis(m_forwardsAxis);
        m_sideway = Input.GetAxis(m_sidewayAxis);
    }

    #endregion

}
