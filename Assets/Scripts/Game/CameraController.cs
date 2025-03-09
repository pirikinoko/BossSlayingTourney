using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera _camera;

    private float cameraMoveDuration = 1f;
    private readonly float fixedZ = -10f;

    private void Awake()
    {
        _camera = GetComponent<Camera>();
    }

    /// <summary>
    /// �J�������w�肳�ꂽ2D�ʒu�Ɉړ������Az�l�����-10�ɌŒ肵�܂��B
    /// </summary>
    /// <param name="targetPosition">�ړ����2D�ʒu�ix, y�j</param>
    public async UniTask MoveCamera(Vector2 targetPosition)
    {
        Vector3 endPosition = new Vector3(targetPosition.x, targetPosition.y, fixedZ);
        await _camera.transform.DOMove(endPosition, cameraMoveDuration).AsyncWaitForCompletion();
    }
}
