using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Events;
using UnityEngine;

public class UnityScript : MonoBehaviour
{

    /************************************************************************
* 컴포넌트 (Component)
* 
* 특정한 기능을 수행할 수 있도록 구성한 작은 기능적 단위
* 게임오브젝트의 작동과 관련한 부품
* 게임오브젝트에 추가, 삭제하는 방식의 조립형 부품
************************************************************************/

    /************************************************************************
	 * MonoBehaviour
	 * 
	 * 게임 오브젝트에 스크립트를 컴포넌트로서 연결할 수 있는 구성을 제공
	 * 스크립트 직렬화 기능, 유니티메시지 이벤트를 받는 기능, 코루틴 기능을 포함함
	 ***********************************************************************/

    // <스크립트 직렬화 기능>
    // 인스펙터 창에서 컴포넌트의 맴버변수 값을 확인하거나 변경하는 기능
    // 컴포넌트의 값형식 데이터를 확인하거나 변경
    // 컴포넌트의 참조형식 데이터를 드래그 앤 드랍 방식으로 연결

    // <인스펙터창 직렬화가 가능한 자료형>
    // private가 아닌 public를 쓰는 이유는 인스펙터창에서 안보임
    [Header("C# Type")]
    public bool boolValue;
    public int intValue;
    public float floatValue;
    public string stringValue;
    // 그 외 기본 자료형

    // 기본 자료형의 선형자료구조
    public int[] array;
    public List<int> list;

    [Header("Unity Type")]
    public Vector3 vector3; // x y z vector2는 2차원 배열로 x y만 가지고 있음
    public Color color;
    public LayerMask layerMask;
    public AnimationCurve curve;
    public Gradient gradient;

    [Header("Unity GameObject")]
    public GameObject obj;

    [Header("Unity Component")]
    public new Transform transform;
    public new Rigidbody rigidbody;
    public new Collider collider;

    [Header("Unity Event")]
    public UnityEvent OnEvent;

    // <어트리뷰트>
    // 클래스, 프로퍼티 또는 함수 위에 명시하여 특별한 동작을 나타낼 수 있는 마커
    // 어트리뷰트는 대괄호[]에다가 작성함
    [Space(30)] // 30만큼의 공간에서 떨어짐

    [Header("Unity Attribute")] // 제목
    [SerializeField] // private지만 인스펙터창에서 보이게 함
    private int privateValue;
    [HideInInspector] // public지만 인스펙터창에서 안보이게 함
    public int publicValue;

    [Range(0, 10)] // 0~10 사이의 슬라이드 바
    public float rangeValue;

    [TextArea(3, 5)] // 여러줄 써야하는 대화지를 쓸 수 있게함
    public string textField;
}
